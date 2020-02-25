using PruebaPizzeria.Infraestructura;
using System;

namespace PruebaPizzeria.Aplication
{
    public class BaseService : IDisposable
    {
        private readonly IUnitOfWork _uow;
        public BaseService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public void Dispose()
        {
            _uow.Dispose();
        }

    }
}