using Microsoft.EntityFrameworkCore;

namespace MVC_Take1.Models
{
    public class DBContextr : DbContext
    {
        public DbSet<User> Users { get; set; }
        

    }
}
