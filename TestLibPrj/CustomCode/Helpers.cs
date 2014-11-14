using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace TestLibPrj.CustomCode
{
    public static class Helpers
    {
        public static bool HasPermission(string controller, string action)
        {
            var user = HttpContext.Current.User.Identity;

            if(controller.Equals("home", StringComparison.InvariantCultureIgnoreCase) &&
                action.Equals("index", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            if((controller.Equals("home", StringComparison.InvariantCultureIgnoreCase) ||
                controller.Equals("account", StringComparison.InvariantCultureIgnoreCase)))
            {
                return true;
            }

            if (!user.IsAuthenticated && action.Equals("index", StringComparison.InvariantCultureIgnoreCase) &&
                (controller != null || !controller.Equals("home", StringComparison.InvariantCultureIgnoreCase)))
            {
                return false;
            }

            return true;
        }

        public static void WriteInformation(string Info)
        {
            var file = new System.IO.StreamWriter("C:\\debug.txt", true);
            file.WriteLine(Info);
            file.Close();
        }
    }
}