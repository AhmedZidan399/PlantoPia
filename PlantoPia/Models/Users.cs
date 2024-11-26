using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.ComponentModel.DataAnnotations;

namespace PlantoPia.Models
{
	public class Users:IdentityUser
	{
		
       // public int Id { get; set; }
		
		[MinLength(20,ErrorMessage ="Name Should be more Than 3 Letters")]
		public string name { get; set; }
		
		public string email { get; set; }
		[RegularExpression("Male | Female",ErrorMessage ="Gender Should be Male or Female")]
        public string Gender { get; set; }
        public string password { get; set; }
		public string phone { get; set; }

        public String ProfileImage { get; set; }
    }
}
