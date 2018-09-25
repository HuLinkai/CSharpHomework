using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Square : Graph
    {
        double a;
        public Square()
        {
            Initialization();
        }
        public override double Area()
        {
            return a * a;
        }
        public override void Initialization()
        {
            Console.Write("请正方形的边长:");
            String rStr = Console.ReadLine();
            try
            {
                a = double.Parse(rStr);
            }
            catch
            {
                Console.WriteLine("输入的值无效");
            }
        }
    }
}
