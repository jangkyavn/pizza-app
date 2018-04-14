using PizzaApp.Model.Enums;
using PizzaApp.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.Data
{
    public class DbInitializer
    {
        public DbInitializer(PizzaAppContext context)
        {
            if (context.Toppings.Count() == 0)
            {
                var toppings = new List<Topping>()
                {
                    new Topping() { Name = "anchovy", Status = Status.Active },
                    new Topping() { Name = "bacon", Status = Status.Active },
                    new Topping() { Name = "basil", Status = Status.Active },
                    new Topping() { Name = "chili", Status = Status.Active },
                    new Topping() { Name = "mozzarella", Status = Status.Active },
                    new Topping() { Name = "mushroom", Status = Status.Active },
                    new Topping() { Name = "olive", Status = Status.Active },
                    new Topping() { Name = "onion", Status = Status.Active },
                    new Topping() { Name = "pepper", Status = Status.Active },
                    new Topping() { Name = "pepperoni", Status = Status.Active },
                    new Topping() { Name = "sweetcorn", Status = Status.Active },
                    new Topping() { Name = "tomato", Status = Status.Active }
                };

                context.Toppings.AddRange(toppings);
                context.SaveChanges();
            }
        }
    }
}
