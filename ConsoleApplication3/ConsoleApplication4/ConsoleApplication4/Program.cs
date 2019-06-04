using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Coffee : IComparable
    {
        public double AverageRating { get; set; }
        public string Variety { get; set; }
        public int CompareTo(object obj)
        {
            Coffee coffee2 = obj as Coffee;
            int result = String.Compare(this.Variety, coffee2.Variety);
            return result;
        }
    }
    public class CoffeeRatingComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Coffee c1 = x as Coffee;
            Coffee c2 = y as Coffee;
            double rating1 = c1.AverageRating;
            double rating2 = c2.AverageRating;
            return rating1.CompareTo(rating2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new Coffee() { AverageRating = 9.0, Variety = "Zumba" });
            al.Add(new Coffee() { AverageRating = 8.0, Variety = "American" });
            al.Add(new Coffee() { AverageRating = 7.0, Variety = "Columbian" });
            al.Add(new Coffee() { AverageRating = 6.0, Variety = "Kava" });
            al.Add(new Coffee() { AverageRating = 5.0, Variety = "Kiwi" });
            al.Add(new Coffee() { AverageRating = 4.0, Variety = "Buffalo" });
            ListCoffees(al);
            al.Sort();
            Console.WriteLine("-------------------");
            ListCoffees(al);
            Console.WriteLine();
            Console.WriteLine("-------------------");
            ListCoffees2(al);
            Console.WriteLine("-------------------");
            al.Sort(new CoffeeRatingComparer());
            ListCoffees2(al);
        }

        private static void ListCoffees(ArrayList al)
        {
            foreach (Coffee item in al)
            {
                Console.WriteLine(item.Variety);
            }
        }
        private static void ListCoffees2(ArrayList al)
        {
            foreach (Coffee item in al)
            {
                Console.WriteLine(item.AverageRating);
            }
        }
    }
}
