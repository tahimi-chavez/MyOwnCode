using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeSomeInterface
{
    public interface IBeverage
    {
        int GetServingTemperature(bool includesMilk);
        bool IsFairTrade { get; set; }
    }
    public class Coffee : IBeverage
    {
        public int GetServingTemperature(bool includesMilk)
        {
            if (includesMilk)
            {
                return 150;
            }
            else
            {
                return 175;
            }
        }
        private bool ift;
        public bool IsFairTrade
        {
            get
            {
                return ift;
            }
            set
            {
                ift = value;
            }
        }
    }
    public class Soda : IBeverage
    {
        public int GetServingTemperature(bool includesMilk = false)
        {
            return 40;
        }
        private bool ift;
        public bool IsFairTrade
        {
            get
            {
                return ift;
            }
            set
            {
                ift = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Coffee c1 = new Coffee() { IsFairTrade = true };
            //Console.WriteLine(c1.GetServingTemperature(false));
            Soda s1 = new Soda();
            Console.WriteLine(s1.GetServingTemperature());
            IBeverage sb1 = c1;
            var c2 = sb1;
            IBeverage[] ibs = new IBeverage[2];
            ibs[0] = c1;
            ibs[1] = s1;
            foreach (IBeverage item in ibs)
            {
                Console.WriteLine(item.GetServingTemperature(false));
            }
            Console.Read();
        }
    }
}
