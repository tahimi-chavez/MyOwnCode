using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{

    class Program
    {
        static void Main(string[] args)
        {
            //Beverage b = new Beverage();
            Espresso e = new Espresso("Red Eye");
            Console.WriteLine(e.Name);
            e.Name = "Bob's Mud";
            e.ServeAt();
            Console.WriteLine(e.Name);
            Console.Read();
        }
    }
}
