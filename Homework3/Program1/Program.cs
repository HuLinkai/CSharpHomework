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
            Console.WriteLine("想要打印的图形并计算出面积");
            Console.WriteLine("1、圆形，2、正方形，3、长方形，4、三角形");
            string type = Console.ReadLine();
            Graph graph = Factory.Create(type);
            if(graph != null)
            {
                Console.WriteLine("面积为：" + graph.Area());
                switch (type)
                {
                    case "1":
                        Console.WriteLine("输出的圆形");
                        break;
                    case "2":
                        Console.WriteLine("输出的正方形");
                        break;
                    case "3":
                        Console.WriteLine("输出的长方形");
                        break;
                    case "4":
                        Console.WriteLine("输出的三角形");
                        break;
                }
            }
        }
    }
}
