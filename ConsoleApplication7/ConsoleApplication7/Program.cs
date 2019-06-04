using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = -10; i < 25; i++)
            {

                bool test = Convert.ToBoolean(i);
                Console.WriteLine("int {0} is {1} bool",i,test); 
            }
            Console.Read();
        }
    }
}
