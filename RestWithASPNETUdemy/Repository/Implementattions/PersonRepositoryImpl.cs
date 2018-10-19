using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository.Generic;
using RestWithASPNETUdemy.VO;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Business.Implementattions
{
    public class PersonRepositoryImpl : GenericRepository<Person>, IPersonRepository
    {
        
        public PersonRepositoryImpl(MySQLContext context) : base (context) { }

        public List<Person> FindByName(string FirstName, string LastName)
        {
            if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
            {
                return _context.Persons.Where(p => p.FirstName.Contains(FirstName) && p.LastName.Contains(LastName)).ToList();
            }
            else if (string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
            {
                return _context.Persons.Where(p => p.LastName.Contains(LastName)).ToList();
            }
            else if (!string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName))
            {
                return _context.Persons.Where(p => p.FirstName.Contains(FirstName)).ToList();
            }
            else
            {
                return _context.Persons.ToList();
            }

        }
    }
}
