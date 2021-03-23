using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoActivity
{
    class Program
    {
        static void Megha()
        {
            Console.WriteLine("Megha's code");
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("This is a demo activity");
            Megha();
            Mrunal();
            Falguni();
            Console.Read();

        }
        static void Mrunal()
        {
            Console.WriteLine("Mrunal code");
        }
        static void Falguni()
        {
            Area a = new Area();
            a.area();
            Console.WriteLine("Falguni code");
            Console.WriteLine("Jenkins demo");
            Console.ReadLine();
        }
    }
}
