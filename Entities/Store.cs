using Oportuno.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Oportuno.Entities
{
    public partial class Store
    {
         [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Email {get; set;}

        [Required]
        [MaxLength(250)]
        public string Phone {get; set;}

        [Required]
        [MaxLength(250)]
        public string Adress {get; set;}

        [Required]
        public string Image {get; set;}

        [Required]
        public string AboutMe { get; set; }

        
        [Required]
        public ServiceType StoreService{get; set;}

        // represent list of store workers
        public ICollection<StoreStuff> Stuff { get; set; }
            = new List<StoreStuff>();
    }

}