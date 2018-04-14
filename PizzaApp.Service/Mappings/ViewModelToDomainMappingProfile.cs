using AutoMapper;
using PizzaApp.Model.Models;
using PizzaApp.Service.ViewModels;

namespace PizzaApp.Service.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ToppingViewModel, Topping>();
        }
    }
}
