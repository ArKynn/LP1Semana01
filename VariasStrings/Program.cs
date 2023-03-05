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

            string x = "2";
            string y = "4";
            string z = "6";

            string xy = x + y;
            string yz = "4" + z;
            string interpolation = $"valor de x = {x}";
            string.Format("Y e' {1}, X e'{0}", x, y);
            Console.WriteLine(@"Verbatim com x = {0}", x);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(xy);
            Console.WriteLine(yz);
            Console.WriteLine(interpolation);


        }
    }
}
