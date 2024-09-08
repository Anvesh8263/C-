using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Anvesh = 30; // Integer Variable
            /* Data Types in C#
             * Integer  - int Anvesh
             * Floapting point number - dloat that;
             * Character - char a = 'A';
             * Boolean - bool is Great = true;
             * String - string inp = "Anvesh";
             */
            //string inp = Console.ReadLine();
            //Console.WriteLine(inp);
            //Console.WriteLine("Hello World");
            //Console.Write("Hello Anvesh");
            //Console.Write("I Love C# and the Number which is my Favourite is:" + Anvesh);
            // TypeCasting double to Float

            /*int a = 34;
            float b = 34.4F;
            double c = 34.4;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            */

            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Heyy Hello " + name);
            Console.ReadLine();

        }
        
    }
}
