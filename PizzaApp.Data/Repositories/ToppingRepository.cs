using PizzaApp.Data.Infrastructures;
using PizzaApp.Model.Models;

namespace PizzaApp.Data.Repositories
{
    public interface IToppingRepository : IRepository<Topping>
    {

    }

    public class ToppingRepository : RepositoryBase<Topping>, IToppingRepository
    {
        public ToppingRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
