using AspNetUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetUdemy.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person p);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person p);
        void Delete(long id);

    }
}
