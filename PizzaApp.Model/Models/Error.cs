using System;

namespace PizzaApp.Model.Models
{
    public class Error
    {
        public int Id { set; get; }

        public string Message { set; get; }

        public string StackTrace { set; get; }

        public DateTime DateCreated { set; get; }
    }
}
