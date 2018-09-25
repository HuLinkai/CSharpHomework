using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Rectangle : Graph
    {
        double a, b;
        public Rectangle()
        {
            Initialization();
        }
        public override double Area()
        {
            return a * b;
        }
        public override void Initialization()
        {
            Console.Write("请长方形的长:");
            String rStr1 = Console.ReadLine();
            Console.Write("请长方形的宽:");
            String rStr2 = Console.ReadLine();
            try
            {
                a = double.Parse(rStr1);
                b = double.Parse(rStr2);
            }
            catch
            {
                Console.WriteLine("输入的值无效");
            }
        }
    }
}
