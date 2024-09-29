using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Snai3i_DAL.Data.Configration;
using Snai3i_DAL.Data.Models;
namespace Snai3i_DAL.Data.Context
{
    public class SnaiiDBContext : DbContext
    {
        public SnaiiDBContext(DbContextOptions<SnaiiDBContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //The following code will set ON DELETE NO ACTION to all Foreign Keys
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.NoAction;

            }

            //call WorkerEntityTypeConfiguration
            //new WorkerEntityTypeConfiguration().configure(modelBuilder.Entity<Worker>());
            //modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            


        }

        public DbSet<User> users { get; set; }

        public DbSet<Worker> workers { get; set; }

        public DbSet<Craft> crafts { get; set; }

        public DbSet<Order> orders { get; set; }

        public DbSet<Review> reviews { get; set; }

        public DbSet<Chat> chats { get; set; }

        public DbSet<Tool> tools { get; set; }

        public DbSet<Size> sizes { get; set; }

        public DbSet<Card> cards { get; set; }

        public DbSet<Sales> sales { get; set; }


        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                var entity = entry.Entity;

                if (entry.State == EntityState.Deleted && entity is Isoftdelete)
                {
                    entry.State = EntityState.Unchanged;
                    entity.GetType().GetProperty("Isdeleted").SetValue(entity, true);
                }
            }

            return base.SaveChanges();
        }


    }
}


