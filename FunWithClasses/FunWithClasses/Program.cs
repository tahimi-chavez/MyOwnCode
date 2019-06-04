using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClasses
{

    class Espresso
    {
        public static string BeverageType { get { return "Espresso"; } }
        public  int Strength { get; set; }
        public  string Bean { get; set; }
        static Espresso()
        {
            Strength = 9;
            Bean = "Kava";
        }
        //public Coffee(int s, string b)
        //{
        //    Strength = s;
        //    Bean = b;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Coffee c1 = new Coffee();
            //Coffee c2 = new Coffee() { Strength = 7, Bean = "Kava" };
            Console.WriteLine(Espresso.BeverageType);
            //c1.Bean = "Java";
            //c1.Strength = 5;
            Program p2 = new Program();
            p2.Doit1();
            Program.Doit2();
            
            Console.Read();
        }
        public void Doit1()
        {
        }
        public static void Doit2()
        {
        }
    }
}
