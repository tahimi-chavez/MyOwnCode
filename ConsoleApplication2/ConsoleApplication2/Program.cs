using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    enum Cars : byte { Ford=5, GM=7, Mazda, Porsche, Toyota, Jeep, myCar=Jeep };

    class Program
    {
        static void Main(string[] args)
        {
            Cars myCar = Cars.Jeep;
            Cars myCar2 = Cars.myCar;

            if (myCar.Equals(myCar2))
                Console.WriteLine("Cars ar equal");
            else
                Console.WriteLine("Cars ar not the same branch");
            Console.Read();
        }
    }
}
