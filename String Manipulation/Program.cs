using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string greetings = "Hello World!";
            string first_name = "Geoffrey";
            string second_name = "Julie.peterson";
            string third_name = "CarlsonJamieMurdoch";

            Console.WriteLine($"The original title for the greeting is {greetings}, which is common in most programming languages.");
            Console.WriteLine($"The name for the first student is {first_name}.");
            Console.WriteLine($"The name for the second student is {second_name}.");
            Console.WriteLine($"The name for the third student is {third_name}.");

            Console.WriteLine("\nModified Code: ");
            Console.WriteLine("String Replacement:");

            //String replacement
            string oldword = "Hello";
            string newword = "hello";
            var newGreetings = greetings.Replace(oldword, newword);
            Console.WriteLine($"The new greetings are: {newGreetings}.");

            //String contains
            Console.WriteLine("\nString Contains:");
            string checkFor = "G";
            string replaceWith = "F";
            var first_nameCheck = first_name.Contains(checkFor);
            Console.WriteLine($"First name has been checked for the letter {checkFor} and this is {first_nameCheck}.");

            //String find and replace
            Console.WriteLine("\nString Find and Replace:");
            var first_replace = first_name.Replace(checkFor, replaceWith);
            Console.WriteLine($"The letter {checkFor} in the name {first_name} has been replaced with {replaceWith}. \nThe new name is {first_replace}");

            //String name split and make uppercase
            Console.WriteLine("\nString Split and make uppercase:");
            string[] second_split = second_name.Split('.' , ' ');

            int count = 0;
            string split_number = "";
            foreach(var split in second_split)
            {
                count++;
                if (count == 1)
                {
                    split_number = "First";
                    Console.WriteLine($"The {split_number} name is : {split}.");
                }
                else if (count == 2)
                {
                    split_number = "Second";
                    var second_upper = char.ToUpper(split[0]);
                    Console.WriteLine($"The upper case letter is: {second_upper}.");
                    Console.WriteLine($"The {split_number} name is : {second_upper+split.Substring(1)}.");
                }
            }
            // String referencing and enumeration
            Console.WriteLine("\nString Referencing: ");
            Console.WriteLine(third_name.Clone());
            Console.WriteLine($"The hash code for this name is: {third_name.GetHashCode()}.");

            CharEnumerator enumeration = third_name.GetEnumerator();
            while (enumeration.MoveNext())
            {
                Console.WriteLine(enumeration.Current);
            }
        }
    }
}
