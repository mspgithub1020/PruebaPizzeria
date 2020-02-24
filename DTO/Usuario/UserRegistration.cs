using System.ComponentModel.DataAnnotations;

namespace PruebaPizzeria.DTO.Usuario
{
    public class UserRegistration
    {
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}