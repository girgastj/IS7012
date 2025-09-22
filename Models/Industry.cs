using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatGirgastj.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Industry Name")]
        public string Name { get; set; }

        [DisplayName("Candidates")]
        public List<Candidate> Candidates { get; set; }

        [DisplayName("Companies")]
        public List<Company> Companies { get; set; }
    }
}
