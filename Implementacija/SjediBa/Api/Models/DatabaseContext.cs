using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SjediBa.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base() {

        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        { }

        public DbSet<UserModel> korisnici { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:sjedibalfp.database.windows.net,1433;Initial Catalog=SjediBa;Persist Security Info=False;User ID=lanajurcevic1;Password=Ljeto123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<UserModel>().ToTable("User");
        }
    }
}