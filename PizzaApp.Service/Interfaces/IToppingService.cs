using PizzaApp.Service.ViewModels;
using System.Collections.Generic;

namespace PizzaApp.Service.Interfaces
{
    public interface IToppingService
    {
        IEnumerable<ToppingViewModel> GetAll();
    }
}
