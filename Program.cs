using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration!");

       UC1_ValidFirstName obj=new UC1_ValidFirstName();
            string FirstName, LastName, email, number, password;

            Console.WriteLine("Enter First Name: ");
            FirstName = Console.ReadLine();
            obj.validateFirstName(FirstName);
            
            LastName = Console.ReadLine();
            obj.validateFirstName(LastName);

            number = Console.ReadLine();
            obj.validateFirstName(number);

            email = Console.ReadLine();
            obj.validateFirstName(email);

            password = Console.ReadLine();
            obj.validateFirstName(password);

        }
    }


}
