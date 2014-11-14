using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestLibPrj.Models;
using TestLibPrj.Models.Repositories;

namespace TestLibPrj.Controllers
{
    public class BooksController : ApiController
    {

        static IBookRepository _repository;
        public BooksController(IBookRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }
            _repository = repository;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _repository.GetAll();
        }

        public Book GetBook(int id)
        {
            Book book = _repository.Get(id);
            if (book == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            return book;
        }
    }
}