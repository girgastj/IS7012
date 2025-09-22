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
    public class IndexModel : PageModel
    {
        private readonly RecruitCatGirgastj.Data.RecruitCatGirgastjContext _context;

        public IndexModel(RecruitCatGirgastj.Data.RecruitCatGirgastjContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidates
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).ToListAsync();
        }
    }
}
