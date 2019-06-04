using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersAreABlast
{
    struct Menu
    {
        private string[] beverages;
        public string this[int index]
        {
            get { return this.beverages[index]; }
            set { this.beverages[index] = value; }
        }
        public int this[string name]
        {
            get {
                for (int i = 0; i < this.beverages.Length; i++)
                {
                    
               
                    if (this.beverages[i] == name)
                    {
                        return i;
                    }
                }
                return -99;
            }
        }
        public Menu(string b1)
        {
            beverages = new string[] { "Americano", "Cafe au Lait", "Cafe Macchiato", "Cappuccino", "Espresso" };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Menu myMenu = new Menu("abc");
            string firstDrink = myMenu[0];
            Console.WriteLine(firstDrink);

            int anotherdrink = myMenu["Espresso"];
            Console.WriteLine(anotherdrink);

            Console.Read();
        }
    }
}
