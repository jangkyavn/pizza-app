using PizzaApp.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace PizzaApp.Data.Configurations
{
    public class PizzaConfiguration : EntityTypeConfiguration<Pizza>
    {
        public PizzaConfiguration()
        {
            ToTable("Pizzas");
            HasKey(p => p.Id);

            Property(p => p.Name).IsRequired().HasMaxLength(255);
        }
    }
}
