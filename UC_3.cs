using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
  public  class UC_3
    {
        public class UserRegistration
        {
          
            public static string Regex_Email = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";

         

            public static bool validateEmail(string email)
            {
                return Regex.IsMatch(email, Regex_Email);
            }

            public static void checkemail(string email)
            {
                if (Regex.IsMatch(email, Regex_Email) == false)
                {
                    Console.WriteLine("Enter valid email address!");
                }
            }


        }
    }
}

