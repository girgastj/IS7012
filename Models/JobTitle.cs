using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatGirgastj.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Job Title")]
        public string Title { get; set; }

        [Range(0, 100000)]
        [DisplayName("Minimum Salary")]
        public decimal MinimumSalary { get; set; }

        [Range(0, 100000)]
        [DisplayName("Maximum Salary")]
        public decimal MaximumSalary { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Experience Needed")]
        public string ExperienceNeeded { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Remote Eligible")]
        public string RemoteEligible { get; set; }

        [Range(0, 500)]
        [DisplayName("Open Positions")]
        public int OpenPositions { get; set; }

        [DisplayName("Candidates")]
        public List<Candidate> Candidates { get; set; }
    }
}
