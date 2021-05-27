using AspNetUdemy.Model;
using System.Collections.Generic;

namespace AspNetUdemy.Business
{
    public interface IBookBusiness
    {
        Book Create(Book p);
        Book FindByID(long id);
        List<Book> FindAll();
        Book Update(Book p);
        void Delete(long id);
    }
}
