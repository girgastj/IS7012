using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatGirgastj.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [Range(0, 1000000)]
        [DisplayName("Target Salary")]
        public decimal TargetSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; } 

        [Required]
        [EmailAddress]
        [DisplayName("Email Address")]
        public string Email { get; set; }

        [Range(0, 50)]
        [DisplayName("Years of Experience")]
        public int YearsExperience { get; set; }

        [DisplayName("Currently Employed")]
        public bool HasCurrentPosition { get; set; }


        [DisplayName("Company")]
        public int? CompanyId { get; set; }   
        public Company Company { get; set; }

        [Required]
        [DisplayName("Job Title")]
        public int JobTitleId { get; set; }   
        public JobTitle JobTitle { get; set; }

        [Required]
        [DisplayName("Industry")]
        public int IndustryId { get; set; }   
        public Industry Industry { get; set; }
    }
}
