using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentierSuperApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ExpenceType> ExpenceTypes { get; set; }
        public virtual DbSet<RealEstate> RealEstates { get; set; }
        public virtual DbSet<RealEstateExpence> RealEstateExpences { get; set; }
        public virtual DbSet<Member> Members { get; set; }
    }

    public class ExpenceType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RealEstateExpence> RealEstateExpences { get; set; }
    }

    public class RealEstate
    {
        [Key]
        public int Id { get; set; }

        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual User { get; set; }
    }

    public class RealEstateExpence
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(RealEstate))]
        public int RealEstateId { get; set; }
        public virtual RealEstate RealEstate { get; set; }

        [ForeignKey(nameof(ExpenceType))]
        public int ExpenceTypeId { get; set; }
        public virtual ExpenceType ExpenceType { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }

    public class Member
    {
        [Key, ForeignKey(nameof(IdentityUser))]
        public string Id { get; set; }
        public virtual IdentityUser IdentityUser { get; set; }
        public string email;

        public virtual ICollection<RealEstate> RealEstates { get; set; }
    }
}