using System.ComponentModel.DataAnnotations;

namespace Oportuno.Entities
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string FirstName {get; set;}

        [Required]
        [MaxLength(250)]
        public string LastName {get; set;}

        [Required]
        [MaxLength(250)]
        public string Email { get; set;}

        [Required]
        [MaxLength(250)]
        public string Phone {get; set;}

        [MaxLength(250)]
        public string AboutMe { get; set; }

        public string Image {get; set;}
    }
}