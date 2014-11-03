using System;
using System.ComponentModel.DataAnnotations;

namespace BlogApplication.Models
{
    public class AboutInformationViewModel
    {
        public int AboutInformationId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}"), Required]
        public DateTime BirthDate { get; set; }
        public string AboutMe { get; set; } 
    }
}