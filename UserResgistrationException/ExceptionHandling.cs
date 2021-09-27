using System;
using System.Collections.Generic;
using System.Text;

namespace UserResgistrationException
{
    //Creating Class for user defined exception
    public class ExceptionHandling : Exception
    {

        // enum for customdatatype
        //custom Exception type
        public enum CustomExceptionsType
        {
            INVALID_INPUT
        }
        //variable
        public CustomExceptionsType customMessage;
        //constructor
        public ExceptionHandling(CustomExceptionsType custom, string message) : base(message)
        {
            this.customMessage = custom;
        }
    }


}




