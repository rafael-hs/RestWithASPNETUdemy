using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.VO;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO PersonVO);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        List<PersonVO> FindByName(string fistName, string lastName);
        PersonVO Update(PersonVO PersonVO);
        void Delete(long id);
    }
}
