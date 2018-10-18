using RestWithASPNETUdemy.Model;
using System;

namespace RestWithASPNETUdemy.Business
{
    public interface ILoginBusiness
    {
        Object FindByLogin(User user);
    }
}
