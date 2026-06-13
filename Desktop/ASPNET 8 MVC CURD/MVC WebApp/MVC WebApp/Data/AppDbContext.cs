using Microsoft.EntityFrameworkCore;
using MVC_WebApp.Models;

namespace MVC_WebApp.Data
{

    //primary Contructor 
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet <User> Users { get; set; }     
       

    }
}
