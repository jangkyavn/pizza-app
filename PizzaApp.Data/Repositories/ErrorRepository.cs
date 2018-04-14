using PizzaApp.Data.Infrastructures;
using PizzaApp.Model.Models;

namespace PizzaApp.Data.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {

    }

    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
