using PruebaPizzeria.DTO;
using PruebaPizzeria.Dominio;
using PruebaPizzeria.Infraestructura;
using PruebaPizzeria.DTO.Usuario;

namespace PruebaPizzeria.Aplication
{
    class UserService : BaseService, IUserService
    {
        private readonly IUserContext _context;
        public UserService(IUserContext context) : base(context)
        {
            _context = context;
        }

        public UserRegistered Register(UserRegistration userRegistration)
        {
            var user = User.Create(userRegistration);
            _context.User.Add(user);
            _context.SaveChanges();
            return UserRegistered.Create(user);
        }

        
    }
}