using AutoMapper;
using PizzaApp.Data.Infrastructures;
using PizzaApp.Data.Repositories;
using PizzaApp.Model.Models;
using PizzaApp.Service.Interfaces;
using PizzaApp.Service.ViewModels;

namespace PizzaApp.Service.Implementation
{
    public class ErrorService : IErrorService
    {
        private readonly IErrorRepository _errorRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ErrorService(
            IErrorRepository errorRepository,
            IUnitOfWork unitOfWork)
        {
            _errorRepository = errorRepository;
            _unitOfWork = unitOfWork;
        }

        public void Create(ErrorViewModel errorViewModel)
        {
            var error = Mapper.Map<ErrorViewModel, Error>(errorViewModel);

            _errorRepository.Add(error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
