using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatGirgastj.Data;
using RecruitCatGirgastj.Models;

namespace RecruitCatgirgastj.Pages.Industries
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatGirgastj.Data.RecruitCatGirgastjContext _context;

        public DetailsModel(RecruitCatGirgastj.Data.RecruitCatGirgastjContext context)
        {
            _context = context;
        }

        public Industry Industry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var industry = await _context.Industries.FirstOrDefaultAsync(m => m.IndustryId == id);

            if (industry is not null)
            {
                Industry = industry;

                return Page();
            }

            return NotFound();
        }
    }
}
