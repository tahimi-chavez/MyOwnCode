using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();
            q1.Enqueue(7);
            q1.Enqueue("ABC");
            int x = (int)q1.Dequeue();
            string s = (string)q1.Dequeue();

            Queue<int> qi = new Queue<int>();
            qi.Enqueue(7);
            qi.Enqueue(18);
            int y = qi.Dequeue();
            Dictionary<int, string> dict = new Dictionary<int, string>();
            Queue<string> qs = new Queue<string>();
            qs.Enqueue("7");

            Queue<object> qo = new Queue<object>();
            qo.Enqueue(7);
            qo.Enqueue("ABC");
            int z = (int)qo.Dequeue();
        }
    }
}
