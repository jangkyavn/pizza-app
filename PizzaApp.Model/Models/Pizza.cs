using PizzaApp.Model.Enums;
using PizzaApp.Model.Interfaces;
using System;

namespace PizzaApp.Model.Models
{
    public class Pizza : IDateTracking, ISwitchable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ToppingId { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public Status Status { get; set; }

        public virtual Topping Topping { get; set; }
    }
}
