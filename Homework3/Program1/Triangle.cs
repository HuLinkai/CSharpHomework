using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Triangle : Graph
    {
        double a, b;
        public Triangle()
        {
            Initialization();
        }
        public override double Area()
        {
            return a * b / 2;
        }
        public override void Initialization()
        {
            Console.Write("请输入三角形的底边长:");
            String rStr1 = Console.ReadLine();
            Console.Write("请输入三角形的宽高:");
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
