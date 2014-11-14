using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TestLibPrj.Models;

namespace WebAPIRc.Models
{
    public class BookStore : DbContext
    {
        public BookStore() :
            base("DefaultConnection")
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}