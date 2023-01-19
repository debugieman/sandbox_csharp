using Microsoft.EntityFrameworkCore;

namespace Test_MVC.Data.Entities
{
    public class User : DbContext

    {
        public DbSet<User> Users { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


    }
    public classB

}

    
