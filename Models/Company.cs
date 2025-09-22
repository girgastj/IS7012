using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatGirgastj.Models
{
    public class Company
    {
        public int CompanyId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Company Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Position Name")]
        public string PositionName { get; set; }
        
        [Range(0, 1000000)]
        [DisplayName("Minimum Salary")]
        public decimal MinimumSalary { get; set; }

        [Range(0, 1000000)]
        [DisplayName("Maximum Salary")]
        public decimal MaximumSalary { get; set; }


        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }

        [Required]
        [StringLength(200)]
        [DisplayName("Location")]
        public string Location { get; set; }

        [Required]
        [Url]
        [DisplayName("Website")]
        public string Website { get; set; }

        [Range(0, 10000000000)]
        [DisplayName("Company Revenue")]
        public decimal CompanyRevenue { get; set; }


        [DisplayName("Currently Hiring")]
        public bool IsHiring { get; set; }

        [Required]
        [DisplayName("Industry")]
        public int IndustryId { get; set; }
        public Industry Industry { get; set; }

        [DisplayName("Candidates")]
        public List<Candidate> Candidates { get; set; }
    }
}
