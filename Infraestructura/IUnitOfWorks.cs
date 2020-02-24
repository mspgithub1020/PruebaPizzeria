namespace PruebaPizzeria.Infraestructura
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        void Dispose();
    }
}