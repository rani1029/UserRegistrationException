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
        //Exception handling for Email
        public void Email()
        {
            const string RegexEmail = @"^[A-Za-z0-9]+([\.+\-_][A-Za-z0-9]+)*@[a-zA-Z0-9]+\.?[A-Za-z]+\.?[A-Za-z]{2,}$";

            Console.WriteLine("Enter Email");
            string Email = Console.ReadLine();
            try
            {
                bool validation3 = Regex.IsMatch(Email, RegexEmail);
                if (validation3 == true)
                    Console.WriteLine("Email is valid " + validation3);
                else
                {
                    throw new ExceptionHandling(ExceptionHandling.CustomExceptionsType.INVALID_INPUT, "invalid Email");
                }
            }
            catch (ExceptionHandling ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //uc-4
        //Exception handling for PhoneNumber
        public void PhoneNumber()
        {
            string RegexPhoneNumber = "^[1-9]{1,2}[ ][1-9]{1}[0-9]{9}$";

            Console.WriteLine("Enter PhoneNumber");
            string PhoneNumber = Console.ReadLine();
            try
            {
                bool validation3 = Regex.IsMatch(PhoneNumber, RegexPhoneNumber);
                if (validation3 == true)
                    Console.WriteLine("PhoneNumber is valid " + validation3);
                else
                {
                    throw new ExceptionHandling(ExceptionHandling.CustomExceptionsType.INVALID_INPUT, "invalid PhoneNumber");
                }
            }
            catch (ExceptionHandling ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //uc-4
        //Exception handling for PhoneNumber
        public void PasswordMin8charactor()
        {
            string RegexPassword = "^[a-zA-Z0-9_!-+@#$]{8,}$";

            Console.WriteLine("Enter Password");
            string Password = Console.ReadLine();
            try
            {
                bool validation3 = Regex.IsMatch(Password, RegexPassword);
                if (validation3 == true)
                    Console.WriteLine("Password is valid " + validation3);
                else
                {
                    throw new ExceptionHandling(ExceptionHandling.CustomExceptionsType.INVALID_INPUT, "invalid Password");
                }
            }
            catch (ExceptionHandling ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
