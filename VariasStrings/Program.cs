using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string greet1 = "\"Hello!\"";
            string greet2 = "Hi!";
            string greet3 = @"How\n are\n you?";
            string unicode1 = "Warning Sign:\u26A0"; 
            string unicode2 = "Open Box Sign:\u2423";

            Console.WriteLine(greet1);
            Console.WriteLine(greet2);
            Console.WriteLine(greet3);
            Console.WriteLine(unicode1);
            Console.WriteLine(unicode2);
        }
    }
}
