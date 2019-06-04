using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodA();
            Console.Read();
        }
        static void MethodA()
        {
            MethodB();
            
        }
        static void MethodB()
        {
            MethodC();
        }
        static void MethodC()
        {
            int x = 7;
            int z = 0;
            try
            {
                int y = x / z;
            }
            finally
            {
                Console.WriteLine("Finally!");
            }

        }
    }
}
