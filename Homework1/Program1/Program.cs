using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "";
            double a, b = 0;
            Console.Write("Please input num(a):");
            s = Console.ReadLine();
            a = double.Parse(s);
            Console.Write("Please input num(b):");
            s = Console.ReadLine();
            b = double.Parse(s);
            double c = a * b;
            Console.WriteLine("a * b = {0}", c);


        }
    }
}
