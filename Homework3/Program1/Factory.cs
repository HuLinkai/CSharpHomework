using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Factory
    {
        public static Graph Create(String type)
        {
            Graph graph = null;
            switch(type)
            {
                case "1":
                    return graph = new Circle();
                case "2":
                    return graph = new Square();
                case "3":
                    return graph = new Rectangle();
                case "4":
                    return graph = new Triangle();
            }
            return null;
        }
    }
}
