using Microsoft.Build.Framework;
using RentierSuperApp.Data;

namespace RentierSuperApp.Models
{
    public class User
    {
        [Required]
        public string Id { get; set; }  
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public virtual ICollection<RealEstate> RealEstates { get; set; }


    }
}
