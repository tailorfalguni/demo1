using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoActivity
{
    class Area
    {
        public void area()
        {
            Console.WriteLine("Enter length");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            int y = int.Parse(Console.ReadLine());

            int result = x * y;
            Console.WriteLine("Area: " + result);
        }
        public void C_area()
        {
            Console.WriteLine("Enter radius:");
            int r = int.Parse(Console.ReadLine());
            double area = (double)(Math.PI) * (double)r * (double)r;
            Console.WriteLine("Area of circle: " + area);
        }
    }
}
