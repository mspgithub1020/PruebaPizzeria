using PruebaPizzeria.Dominio;
using Microsoft.EntityFrameworkCore;

namespace PruebaPizzeria.Infraestructura
{
    public class UserConfiguration
    {
        public static void Apply(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasKey(user => user.Id);
        }
    }
}