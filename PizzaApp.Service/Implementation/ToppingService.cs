using AutoMapper;
using PizzaApp.Data.Infrastructures;
using PizzaApp.Data.Repositories;
using PizzaApp.Model.Models;
using PizzaApp.Service.Interfaces;
using PizzaApp.Service.ViewModels;
using System.Collections.Generic;

namespace PizzaApp.Service.Implementation
{
    public class ToppingService : IToppingService
    {
        private readonly IToppingRepository _toppingRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ToppingService(
            IToppingRepository toppingRepository,
            IUnitOfWork unitOfWork)
        {
            _toppingRepository = toppingRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<ToppingViewModel> GetAll()
        {
            var model = _toppingRepository.GetAll();

            return Mapper.Map<IEnumerable<Topping>, IEnumerable<ToppingViewModel>>(model);
        }
    }
}
