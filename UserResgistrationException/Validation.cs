using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserResgistrationException
{
    public class Validation
    {
        //Exception handling for firstname
        public void FirstName()
        {
            string RegexFirstName = "^[A - Z]{ 1}[a-z]{ 2,}$";

            Console.WriteLine("enter valid first name");
            string Firstname = Console.ReadLine();
            try
            {
                bool validation = Regex.IsMatch(Firstname, RegexFirstName);
                if (validation == true)
                    Console.WriteLine("firstname is valid " + validation);
                else
                    throw new ExceptionHandling(ExceptionHandling.CustomExceptionsType.INVALID_INPUT, "invalid firstName");
            }
            catch (ExceptionHandling ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        //Exception handling for Lastname
        public void LastName()
        {
            string RegexLastName = "^[A - Z]{ 1}[a-z]{ 2,}$";

            Console.WriteLine("enter valid Last name");
            string Firstname = Console.ReadLine();
            try
            {
                bool validation = Regex.IsMatch(Firstname, RegexLastName);
                if (validation == true)
                    Console.WriteLine("Lastname is valid " + validation);
                else
                    throw new ExceptionHandling(ExceptionHandling.CustomExceptionsType.INVALID_INPUT, "invalid lastName");
            }
            catch (ExceptionHandling ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
