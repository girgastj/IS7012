using Microsoft.EntityFrameworkCore;
using RecruitCatGirgastj.Models;

namespace RecruitCatGirgastj.Data
{
    public class RecruitCatGirgastjContext : DbContext
    {
        public RecruitCatGirgastjContext(DbContextOptions<RecruitCatGirgastjContext> options)
            : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; } = default!;
        public DbSet<Company> Companies { get; set; } = default!;
        public DbSet<Industry> Industries { get; set; } = default!;
        public DbSet<JobTitle> JobTitles { get; set; } = default!;
    }
}
