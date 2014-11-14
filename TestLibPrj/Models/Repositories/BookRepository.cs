using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIRc.Models;

namespace TestLibPrj.Models.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book Get(int id);
        Book Add(Book item);
        void Remove(int id);
        bool Update(Book item);
    }

    public class BookRepository : IBookRepository
    {
        private BookStore db = new BookStore();

        public BookRepository()
        {
        }

        public IEnumerable<Book> GetAll()
        {
            return db.Books;
        }

        public Book Get(int id)
        {
            return db.Books.Find(id);
        }

        public Book Add(Book item)
        {
            db.Books.Add(item);
            db.SaveChanges();
            return item;
        }

        public void Remove(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
            db.SaveChanges();
        }

        public bool Update(Book item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
    }
}