using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public interface Talk
    {
        void Talk();
    }
    public interface Walk
    {
        void Walk();
    }
    public interface Fly
    {
        void Fly();
    }
    class Animals
    {
        
    }
    class Dog : Talk , Walk
    {

        public void Talk()
        {
            Console.WriteLine("Bark");
        }

        public void Walk()
        {
            Console.WriteLine("Run");
        }
    }
    class Cat : Talk, Walk
    {
        public void Talk()
        {
            Console.WriteLine("Meow");
        }

        public void Walk()
        {
            Console.WriteLine("Climb");
        }

    }
    class Goose : Talk, Walk, Fly
    {
        public void Talk()
        {
            Console.WriteLine("Quack");
        }

        public void Walk()
        {
            Console.WriteLine("Waddle");
        }


        public void Fly()
        {
            Console.WriteLine("Flapping my wings");
        }
    }
}
