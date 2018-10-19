using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository.Generic
{
    public interface IPersonRepository : IRepository<Person>
    {
        List<Person> FindByName(string fistName, string lastName);
        
    }
}
