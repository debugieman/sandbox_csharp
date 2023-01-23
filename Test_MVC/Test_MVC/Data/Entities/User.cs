
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Test_MVC.Data.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


    }
    

}

    
