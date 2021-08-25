using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
   public class UC_4
    {
        public static string Regex_Number = "^[0-9]{2}[ ][6-9][0-9]{9}$";

    

        public static bool validatenumber(string number)
        {
            return Regex.IsMatch(number, Regex_Number);
        }

        public static void checknumber(string number)
        {
            if (Regex.IsMatch(number, Regex_Number) == false)
            {
                Console.WriteLine("Enter valid email address!");
            }
        }

    }
}
    

