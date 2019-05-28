using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        { 
            string s;
        int a, b;
        Console.Write("Калькулятор");
            Console.WriteLine();

            Console.Write("A = ");
            s = Console.ReadLine();
            a = int.Parse(s);

        Console.Write("B = ");
            s = Console.ReadLine();
            b = int.Parse(s);

        Console.WriteLine();
            Console.WriteLine(a + " + " + b + " = " + (a + b) );
            Console.ReadKey();

            Console.WriteLine(a + " - " + b + " = " + (a - b) );
            Console.ReadKey();

            Console.WriteLine(a + " / " + b + " = " + (a / b) );
            Console.ReadKey();

            Console.WriteLine(a + " * " + b + " = " + (a* b) );
            Console.ReadKey();

            Console.WriteLine("a^2" + Math.Pow(a, 2) );
            Console.ReadKey();

            double c = 10;
        double w = 10.0 / 4;
        // Console.WriteLine(" c " + " w " + (c / w) );
        Console.WriteLine(w);
            Console.ReadKey();

            double y = 10;
        double z = y % 5;
        Console.WriteLine(z);
            Console.ReadKey();
            
        }


}


        
    }

