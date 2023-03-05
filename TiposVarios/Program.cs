using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            uint ui = 10U;
            long l = 100L;
            ulong ul = 100UL;

            Console.WriteLine(i);
            Console.WriteLine(ui);
            Console.WriteLine(l);
            Console.WriteLine(ul);

            char arrow1 = '\u2190';
            char arrow2 = '\u219A';
            char arrow3 = '\u21B0';

            Console.WriteLine(arrow1);
            Console.WriteLine(arrow2);
            Console.WriteLine(arrow3);
            
            double d = 12.345;
            float f = 1.2345f;
            decimal de = 0.1234m;

            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(de);

            bool t = true;
            bool fa = false;
            
            Console.WriteLine(t);
            Console.WriteLine(fa);
        }
    }
}
