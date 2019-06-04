using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    class Point
    {
        private int x;
        public int X
        {
            get { return x; }
            set 
            {
                if (value > 0)
                {
                    x = value; 
                }
                else
                {
                    throw new ArgumentException("x must be positive!");
                }
            }
        }
        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void MoveX(int delta)
        {
            x += delta;
        }
        public void MoveY(int delta)
        {
            y += delta;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,1) { X = 15, Y = 17 };

            p1.X= 1;
            p1.Y = 2;
            Point p2 = new Point(10, 20);
            p2.MoveX(100);
            ShowMeThePoints(p1);
            ShowMeThePoints(p2);
            Point[] pointArray = new Point[10];
            Console.Read();
        }
        static void ShowMeThePoints(Point p)
        {
            p.X = 777777;
            p.Y = 7777777;
            Console.WriteLine("x={0}, y={1}", p.X, p.Y);
        }
    }
}
