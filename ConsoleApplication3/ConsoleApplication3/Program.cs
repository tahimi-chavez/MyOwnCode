using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Account
    {
        public decimal Balance { get; set; }
        public void Deposit(decimal amt)
        {
            Balance += amt;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Account() { Balance = 500 };
            a1.Deposit(250);
            Console.Read();
        }
    }
}
