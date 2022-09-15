using CRUD_Web_App.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Web_App.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Users> Users { get; set; }

    }
}
