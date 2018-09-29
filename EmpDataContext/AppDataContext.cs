using Microsoft.EntityFrameworkCore;
using netcoreproject.Models;

namespace netcoreproject.EmpDataContext
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options){

        }

        public DbSet<Employee> Employees { get; set; }

        
    }
}