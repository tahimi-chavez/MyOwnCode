using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    abstract class Beverage
    {
        public string Name { get; set; }
        public virtual void WhatAmI()
        {
            Console.WriteLine("I am a Beverage");
        }
        public abstract void ServeAt();
        public Beverage(string name)
        {
            Console.WriteLine("Beverage constructor");
            Name = name;
        }
    }
    class Coffee : Beverage
    {
        public override void WhatAmI()
        {
            Console.WriteLine("I am a Coffee");
        }
        public override void ServeAt()
        {
            Console.WriteLine("Serve at 200");
        }
        public Coffee(string name) :base(name)
        {
            Console.WriteLine("Coffee constructor");
        }

    }
    class Espresso : Coffee
    {
        public override void ServeAt()
        {
            Console.WriteLine("Serve at 210");
            base.ServeAt();
        }
        public Espresso(string name) :base(name)
        {
            Console.WriteLine("Espresso constructor");
        }

    }
    
}
