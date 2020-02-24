using System;
using PruebaPizzeria.DTO.Usuario;

namespace PruebaPizzeria.Dominio
{
    public class User
    {
        public static User Create(UserRegistration userRegistration)
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Nombre = userRegistration.Nombre,
                Apellido = userRegistration.Apellido,
                Email = userRegistration.Email,
                Password = userRegistration.Password
            };
            return user;
        }
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}