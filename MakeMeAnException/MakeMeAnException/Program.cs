using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MakeMeAnException
{
    public static class SomeUtility
    {
        public static bool ContainsNumbers(this string s)
        {
            return Regex.IsMatch(s, @"\d");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "ABC12";
            if (text.ContainsNumbers())
            {
                Console.WriteLine("{0} has numbers in it", text);
            } else
            {
                Console.WriteLine("{0} does not have numbers in it", text);
            }
            Console.WriteLine(text.Length);
            //try
            //{
            //    MakeTheError();
            //}
            //catch (BobsDemoException e)
            //{
            //    Console.WriteLine("msg: {0}, data: {1}", e.Message, e.WhatsTheProblem);
            //}
            Console.Read();
        }
        static void MakeTheError()
        {
            DivideByZeroException dbze = new DivideByZeroException();
            BobsDemoException e = new BobsDemoException("I made an error", dbze) { WhatsTheProblem = "Not enough time" };
            throw e;
        }
    }
    class BobsDemoException : Exception
    {
        public BobsDemoException()
        {
        }
        public BobsDemoException(string message) : base(message)
        {
        }
        public BobsDemoException(string message, Exception inner) : base(message, inner)
        {
        }
        public string WhatsTheProblem { get; set; }
    }
}
