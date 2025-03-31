using Calender_Webapp.Models;
using Microsoft.EntityFrameworkCore;
namespace Calender_Webapp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Termin> Termine { get; set; }
    }
}
