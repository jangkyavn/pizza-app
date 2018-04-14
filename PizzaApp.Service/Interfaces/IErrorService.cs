using PizzaApp.Service.ViewModels;

namespace PizzaApp.Service.Interfaces
{
    public interface IErrorService
    {
        void Create(ErrorViewModel errorViewModel);

        void Save();
    }
}
