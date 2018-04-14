namespace PizzaApp.Data.Infrastructures
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
