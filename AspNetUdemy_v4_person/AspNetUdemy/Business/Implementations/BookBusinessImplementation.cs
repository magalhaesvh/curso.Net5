using AspNetUdemy.Model;
using AspNetUdemy.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetUdemy.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;

        public BookBusinessImplementation(IRepository<Book> rep)
        {
            _repository = rep;
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Book Create(Book p)
        {
            return _repository.Create(p);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public Book Update(Book p)
        {
            return _repository.Update(p);
        }
    }
}
