using PizzaApp.Model.Enums;
using System;

namespace PizzaApp.Service.ViewModels
{
    public class ToppingViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public Status Status { get; set; }
    }
}
