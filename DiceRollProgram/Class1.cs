using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollProgram
{
    class Error
    {
        // Make an attribute within the whole class that keeps track of error type to be given by the user
        private string errorType = "";

        // Arrays that hold the possible responses from the user
        string[] invalidInt = { "integer", "int","badint","integer dice roll" };
        string[] bugHit = { "bug", "computer bug" };

        // Constructor. Receives parameter of error message type.
        public Error (string type)
        {
            string errorType = type;
        }

        public void PrintError()
        {
            string the_type = errorType;
            if (invalidInt.Contains(the_type))
            {
                Console.WriteLine("You have input a negative number or zero. Please restart program and enter a valid " +
                    "positive integer."); 
            }
            if (bugHit.Contains(the_type))
            {
                Console.WriteLine("You hit a bug. You need to start over.");
            }
        }
        
    }
}
