using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test_MVC.Data.Entities;
using MvcMovie.Models;

namespace Test_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<User> Users {get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

            //klasy  np. user 
            //++ DB sety np . users -
            //konsola: entity -
        }
        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}