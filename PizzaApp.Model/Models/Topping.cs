using PizzaApp.Model.Enums;
using PizzaApp.Model.Interfaces;
using System;
using System.Collections.Generic;

namespace PizzaApp.Model.Models
{
    public class Topping : IDateTracking, ISwitchable
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public Status Status { get; set; }
        
        public virtual ICollection<Pizza> Pizzas { get; set; }
    }
}
