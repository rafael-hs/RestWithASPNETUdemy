using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.VO;
using System;

namespace RestWithASPNETUdemy.Business
{
    public interface ILoginBusiness
    {
        Object FindByLogin(UserVO user);
    }
}
