using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UC1_ValidFirstName
    {

        public  static string REGEX_FIRSTNAME = "^[A-Z][a-z]{2}$";


            public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, REGEX_FIRSTNAME);
        }


        public static void checkFirstName(string FirstName)
        {
            if (Regex.IsMatch(FirstName, REGEX_FIRSTNAME) == false)
            {
                Console.WriteLine("Enter valid First name. It should Start with capital letters and minimum 3 letters!");
            }
            else
            {
                Console.WriteLine("It is Valid!");
            }
        }

    }
}
        


    

