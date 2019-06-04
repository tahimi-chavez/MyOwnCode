using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HooBoy
{
    struct Coffee
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Hashtable and add some drinks with prices.
            Hashtable prices = new Hashtable();
            prices.Add("Café au Lait", 1.99M);
            prices.Add("Caffe Americano", 1.89M);
            prices.Add("Café Mocha", 2.99M);
            prices.Add("Cappuccino", 2.49M);
            prices.Add("Espresso", 1.49M);
            prices.Add("Espresso Romano", 1.59M);
            prices.Add("English Tea", 1.69M);
            prices.Add("Juice", 2.89M);
            // Select all the drinks that cost less than $2.00, and order them by cost.
            var bargains =
               from string drink in prices.Keys
               where (Decimal)prices[drink] < 2.00M
               orderby prices[drink] ascending
               select drink;
            // Display the results.
            foreach (string bargain in bargains)
            {
                Console.WriteLine(bargain);
            }
            Console.ReadLine();

        }
    }
}
