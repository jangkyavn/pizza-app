namespace PizzaApp.Data.Infrastructures
{
    public class DbFactory : Disposable, IDbFactory
    {
        private PizzaAppContext dbContext;

        public PizzaAppContext Init()
        {
            return dbContext ?? (dbContext = new PizzaAppContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
