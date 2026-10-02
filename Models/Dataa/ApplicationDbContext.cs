using Microsoft.EntityFrameworkCore;
using CRUDKuttappan.Models;

namespace CRUDKuttappan.Models.Dataa
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}