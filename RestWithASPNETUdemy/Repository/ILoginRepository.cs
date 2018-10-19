using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.VO;

namespace RestWithASPNETUdemy.Business
{
    public interface ILoginRepository
    {
       User FindByLogin(string login);
    }
}
