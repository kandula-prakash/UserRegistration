using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
   public class UC2_LastName
    {
        public class UserRegistration
        {
       
            public static string Regex_LastName = "^[A-Z][a-z]{2,}$";

        

            public static bool ValidateLastName(string LastName)
            {
                return Regex.IsMatch(LastName, Regex_LastName);
            }

            public static void checkLastName(string LastName)
            {
                if (Regex.IsMatch(LastName, Regex_LastName) == false)
                {
                    Console.WriteLine("Enter valid Last name. It should Start with capital letters and minimum 3 letters!");
                }
            }
        }

    }
}

