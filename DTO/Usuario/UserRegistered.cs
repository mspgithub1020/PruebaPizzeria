using System;
using PruebaPizzeria.Dominio;

namespace PruebaPizzeria.DTO.Usuario
{
    public class UserRegistered
    {
        public static UserRegistered Create(User user)
        {
            var userRegistered = new UserRegistered()
            {
                Id = user.Id,
                Nombre = user.Nombre,
                Apellido = user.Apellido,
                Email = user.Email
            };
            return userRegistered;
        }
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
    }
}


