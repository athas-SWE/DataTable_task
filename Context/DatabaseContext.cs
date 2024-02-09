using Data_table.Models;
using Microsoft.EntityFrameworkCore;

namespace Data_table.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options) : base(options) 
        { 
        }

        public DbSet<Student> Students { get; set; }
    }
}
