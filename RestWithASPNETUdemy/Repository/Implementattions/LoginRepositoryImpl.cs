using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.VO;
using System.Linq;

namespace RestWithASPNETUdemy.Business.Implementattions
{
    public class LoginRepositoryImpl : ILoginRepository
    {
        private readonly MySQLContext _context;

        public LoginRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        public User FindByLogin(string login)
        {
            return _context.User.SingleOrDefault(u => u.Login.Equals(login));
        }

    }
}
