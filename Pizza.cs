using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FebSec4Prj
{
    public class Pizza
    {
        public string Authenticate(string CustomerName, string password)
        {
            string msg;
            if (string.IsNullOrEmpty(CustomerName) || string.IsNullOrEmpty(password))
            {
                msg = "user name and password required ";
            }
            else
            {
                if ((CustomerName == "admin") && (password == "admin123@"))
                {
                    msg = "Authentication pass";
                }
                else
                {
                    msg = "Authentcation fail";
                }
            }
            return "provide user details";
        }
    }
}

