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
            Console.WriteLine("Please enter a number bigger than 2: ");
            String s = "";
            s = Console.ReadLine();
            int a;
            try
            {
                a = int.Parse(s);
            }
            catch
            {
                Console.WriteLine("Please enter a int num");
                return;
            }
            a = int.Parse(s);
            for (int i = 2; i <= a; i++)
            {
                int j;
                if(a % i == 0 )
                {
                    for (j = 2; j <= i; j++)                     
                    {
                        if (i % j == 0)
                            break;
                    }
                    if (i == j)
                        Console.WriteLine(i);
                }
            }
        }
    }
}