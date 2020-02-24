using Microsoft.EntityFrameworkCore;
using System;
using PruebaPizzeria.Dominio;


namespace PruebaPizzeria.Infraestructura
{
    public class EntidadContext : DbContext, IUserContext
    {
        public DbSet<User> User { get; set; }

        public EntidadContext(DbContextOptions<EntidadContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserConfiguration.Apply(modelBuilder);
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                // TODO: throw custom exception
                throw ex;
            }
        }
    }
}