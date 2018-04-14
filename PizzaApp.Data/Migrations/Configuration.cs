namespace PizzaApp.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PizzaApp.Data.PizzaAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PizzaApp.Data.PizzaAppContext context)
        {
            new DbInitializer(context);
        }
    }
}
