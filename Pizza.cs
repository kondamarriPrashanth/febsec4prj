using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FebSec4Prj
{
    public class Pizza
    {
        public string Authenticate(string ShoapName, string Address)
        {
            string msg;
            if (string.IsNullOrEmpty(ShoapName) || string.IsNullOrEmpty(Address))
            {
                msg = "user name and password required ";
            }
            else
            {
                if ((ShoapName == "Slice Delight") && (Address == "Hyd"))
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

