using AutoMapper;
using PizzaApp.Model.Models;
using PizzaApp.Service.ViewModels;

namespace PizzaApp.Service.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Topping, ToppingViewModel>();
        }
    }
}
