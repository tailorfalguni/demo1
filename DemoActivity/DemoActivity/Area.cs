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
    }
}
