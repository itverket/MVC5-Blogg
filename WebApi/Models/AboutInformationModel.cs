using System;

namespace WebApi.Models
{
    public class AboutInformationModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string AboutMe { get; set; }
    }
}