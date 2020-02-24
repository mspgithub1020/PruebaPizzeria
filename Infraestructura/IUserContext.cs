using Microsoft.EntityFrameworkCore;
using PruebaPizzeria.Dominio;


namespace PruebaPizzeria.Infraestructura
{
    public interface IUserContext : IUnitOfWork
    {
        DbSet<User> User { get; set; }
    }
}