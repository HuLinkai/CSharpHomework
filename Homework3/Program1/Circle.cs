using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Circle : Graph
    {
        double r;
        public Circle()
        {
            Initialization();
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(r,2);
        }
        public override void Initialization()
        {
            Console.Write("请输入圆形的半径:");
            String rStr = Console.ReadLine();
            try
            {
                r = double.Parse(rStr);
            }
            catch
            {
                Console.WriteLine("输入的值无效");
            }
        }
    }
}
