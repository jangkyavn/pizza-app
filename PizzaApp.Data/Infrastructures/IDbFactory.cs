using System;

namespace PizzaApp.Data.Infrastructures
{
    public interface IDbFactory : IDisposable
    {
        PizzaAppContext Init();
    }
}
