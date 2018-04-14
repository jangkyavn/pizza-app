using PizzaApp.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PizzaApp.Data.Configurations
{
    public class ToppingConfiguration : EntityTypeConfiguration<Topping>
    {
        public ToppingConfiguration()
        {
            ToTable("Toppings");
            HasKey(t => t.Id);

            Property(t => t.Name).IsRequired().HasMaxLength(50);
        }
    }
}
