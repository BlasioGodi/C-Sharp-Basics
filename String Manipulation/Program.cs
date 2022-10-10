using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string greetings = "Hello World!";
            string first_name = "Geoffrey";
            string second_name = "Julie";
            string third_name = "Carlson";
            string error_message = "The exception was handled accordingly";
            try
            {
                Console.WriteLine($"The original title for the greeting is {greetings}, which is common in most programming languages.");
                Console.WriteLine($"The name for the first student is {first_name}.");
                Console.WriteLine($"The name for the second student is {second_name}.");
                Console.WriteLine($"The name for the third student is {third_name}.");

            }
            catch (Exception e)
            {
                error_message = e.Message;
            }
        }
    }
}
