using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_World.Models
{
	public class AppUser : IdentityUser

    {
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string U_Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Contact { get; set; }


        [Required]
        [Column(TypeName = "varchar(100)")]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Country { get; set; }

       
        [Required]
        public string ProfileImage { get; set; }

        [NotMapped]
        public IFormFile ProfilePicture { get; set; }






    }
}
