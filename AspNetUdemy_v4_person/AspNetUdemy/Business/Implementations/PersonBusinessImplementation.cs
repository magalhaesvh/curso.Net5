using AspNetUdemy.Model;
using AspNetUdemy.Model.Context;
using AspNetUdemy.Repository;
using AspNetUdemy.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;

        public PersonBusinessImplementation(IRepository<Person> rep)
        {
            _repository = rep;
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Person Create(Person p)
        {
            return _repository.Create(p);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public Person Update(Person p)
        {
            return _repository.Update(p);
        }

    
    }
}
