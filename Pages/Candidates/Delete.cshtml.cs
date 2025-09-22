using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatGirgastj.Data;
using RecruitCatGirgastj.Models;

namespace RecruitCatgirgastj.Pages.Candidates
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatGirgastj.Data.RecruitCatGirgastjContext _context;

        public DeleteModel(RecruitCatGirgastj.Data.RecruitCatGirgastjContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Candidate Candidate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidates.FirstOrDefaultAsync(m => m.CandidateId == id);

            if (candidate is not null)
            {
                Candidate = candidate;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidates.FindAsync(id);
            if (candidate != null)
            {
                Candidate = candidate;
                _context.Candidates.Remove(Candidate);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
