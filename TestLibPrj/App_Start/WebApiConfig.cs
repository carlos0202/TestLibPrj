using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TestLibPrj.Controllers;
using TestLibPrj.Models.Repositories;


namespace TestLibPrj.App_Start
{
    public class WebApiConfig
    {
        public static void ConfigureApi(HttpConfiguration config)
        {
            var unity = new UnityContainer();
            unity.RegisterType<BooksController>();
            unity.RegisterType<IBookRepository, BookRepository>(
                new HierarchicalLifetimeManager());
        }
    }
}