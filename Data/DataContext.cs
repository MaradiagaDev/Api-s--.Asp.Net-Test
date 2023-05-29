using ASP.Net_Test.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Test.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> option) : base(option) 
       { 

       }
       //Dta sets
       public DbSet<User> Users { get; set; }
    }
}
