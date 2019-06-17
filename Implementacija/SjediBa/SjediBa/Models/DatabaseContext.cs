using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;

namespace SjediBa.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base() {

        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        { }

        public DbSet<ReservationModel> Rezervacija { get; set; }
        public DbSet<SeatModel> Sjedista { get; set; }
        public DbSet<SectionModel> Sektori { get; set; }
        public DbSet<UserModel> korisnici { get; set; }
        public DbSet<SpaceModel> Lokacije { get; set; }
        public DbSet<OrganizerModel> Oranizatori { get; set; }
        public DbSet<UnregistredUserModel> Neregistrovani { get; set; }
        public DbSet<MainAdministratorModel> Glavni { get; set; }
        public DbSet<AdministratorModel> Administratori { get; set; }
        public DbSet<LocalAdministratorModel> Lokalni { get; set; }
        public DbSet<RegisteredUserModel> Registrovani { get; set; }
        public DbSet<NotificationModel> obav { get; set; }
        public DbSet<EventModel> dogad { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer(
        //         @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
        // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseInMemory(
            //     @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True"
            // );

            // optionsBuilder.UseInMemory(Configuration.GetConnectionString("SjediBaDatabase"));
            // optionsBuilder.UseInMemoryDatabase(databaseName: "SjediBaDatabase");

            // optionsBuilder.UseInMemoryDatabase(databaseName: Configuration.GetConnectionString("SjediBaDatabase"));

            // optionsBuilder.UseSqlServer(databaseName: "SjediBaDatabase");
            // optionsBuilder.UseInMemoryDatabase(databaseName: "SjediBaDatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<ReservationModel>().ToTable("Reservation");
            modelBuilder.Entity<SeatModel>().ToTable("Seat");
            modelBuilder.Entity<SectionModel>().ToTable("Section");
            modelBuilder.Entity<UserModel>().ToTable("User");
            modelBuilder.Entity<UnregistredUserModel>().ToTable("Unregistred User");
            modelBuilder.Entity<AdministratorModel>().ToTable("Administrator");
            modelBuilder.Entity<MainAdministratorModel>().ToTable("Main Administrator");
            modelBuilder.Entity<SpaceModel>().ToTable("Space");
            modelBuilder.Entity<OrganizerModel>().ToTable("Organizer");
            modelBuilder.Entity<LocalAdministratorModel>().ToTable("Local Administrator");
            modelBuilder.Entity< RegisteredUserModel>().ToTable("Registred User");
            modelBuilder.Entity<NotificationModel>().ToTable("Notification");
            modelBuilder.Entity<EventModel>().ToTable("Event");

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}