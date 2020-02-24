using PruebaPizzeria.DTO.Usuario;

namespace PruebaPizzeria.Aplication
{
    public interface IUserService
    {
        UserRegistered Register(UserRegistration userRegistration);
    }
}