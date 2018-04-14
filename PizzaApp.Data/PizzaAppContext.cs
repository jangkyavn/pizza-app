using PizzaApp.Data.Configurations;
using PizzaApp.Model.Interfaces;
using PizzaApp.Model.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace PizzaApp.Data
{
    public class PizzaAppContext : DbContext
    {
        public PizzaAppContext() : base("PizzaAppConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Error> Errors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PizzaConfiguration());
            modelBuilder.Configurations.Add(new ToppingConfiguration());
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

            foreach (var entry in entries)
            {
                var changedOrAddedItem = entry.Entity as IDateTracking;

                if (changedOrAddedItem != null)
                {
                    if (entry.State == EntityState.Added)
                    {
                        changedOrAddedItem.DateCreated = DateTime.Now;
                    }

                    changedOrAddedItem.DateModified = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
