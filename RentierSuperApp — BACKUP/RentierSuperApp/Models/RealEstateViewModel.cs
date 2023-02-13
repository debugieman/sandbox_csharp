using System.ComponentModel.DataAnnotations;

namespace RentierSuperApp.Models
{
    public class RealEstateViewModel
    {
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        





    }
}
