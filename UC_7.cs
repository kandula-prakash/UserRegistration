using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
  public  class UC_7
    {
        public static string Regex_Password = "^((?=.*[A-Z])(?=.*[0-9])(?=.{8,}))";


       

        public static bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }

        public static void checkPassword(string password)
        {
            if (Regex.IsMatch(password, Regex_Password) == false)
            {
                Console.WriteLine("Enter valid password. It should contain minimum 8 character," +
                    "atleast one upper case character and atleast one numeric value");
            }
        }

    }
}
    

