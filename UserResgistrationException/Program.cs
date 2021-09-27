using System;

namespace UserResgistrationException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to userRegistration exception handling!");
            Validation validation = new Validation();
            //validation.FirstName();
            validation.LastName();
        }
    }
}
