using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserResgistrationException
{
    public class Validation
    {
        //string RegexFirstName = "^[A - Z]{ 1}[a-z]{ 2,}$";
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
    }
}
