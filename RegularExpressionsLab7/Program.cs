using System;
using System.Text.RegularExpressions;

namespace RegularExpressionsLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            NameValidate(name);

            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            EmailValidate(email);

            Console.WriteLine("Enter your phone number");
            string phone = Console.ReadLine();
            ValidatePhonenNumbers(phone);

            Console.WriteLine("Enter your birthday");
            string date= Console.ReadLine();
            DateValidation(date);
                
        }
        public static bool NameValidate(string input)
        {
           if( Regex.IsMatch(input, @"([A-z]{1,30}[\ ][A-z]{1,30})"))
            {
                Console.WriteLine("yay");
                return true;
            }
            else
            {
                Console.WriteLine("Boo");
                return false;
            }
        }
        public static bool EmailValidate(string input)
        {
            if (Regex.IsMatch(input, @"([\w\d.]{1,29}[\@][\w\d]{5,10}[\.][a-z]{2,3})"))
            {
                Console.WriteLine("Good email");
                return true;
            }
            else
            {
                Console.WriteLine("That is not an email.");
                return false;
            }

        }
        public static bool ValidatePhonenNumbers(string input)
        {
            if (Regex.IsMatch(input, @"(\(\d{3}\)\d{3}-\d{4})"))
            {
                Console.WriteLine("Thanks for phone number");
                return true;
            }
            else
            {
                Console.WriteLine("That is not the proper phone number format.");
                return false;
            }
        }
        public static bool DateValidation(string input)
        {
            if(Regex.IsMatch(input, @"(\d{2}\/\d{2}\/\d{4})"))
            {
                Console.WriteLine("Thanks for the date");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect date format");
                return true;
            }
        }
    }
}
