using Microsoft.EntityFrameworkCore;
using AngularDemo.API.Models;
namespace AngularDemo.API.Data
{
    public class DataContext : DbContext
    {
      public DataContext(DbContextOptions<DataContext> options) : base (options) 
      {
      }
      public DbSet<Values> ValuesT {get; set;}   
    }
}