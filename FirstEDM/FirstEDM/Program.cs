using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEDM
{
    class Program
    {
        static FourthCoffeeEntities context = new FourthCoffeeEntities();
        static void Main(string[] args)
        {
            var emps = from e in context.Employees
                       select new { e.LastName, e.FirstName };
            foreach (var item in emps)
            {
                Console.WriteLine(item.LastName);
            }
            Console.Read();
        }
    }
}
