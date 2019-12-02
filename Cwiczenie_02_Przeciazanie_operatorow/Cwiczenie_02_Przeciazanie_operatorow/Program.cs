using System;

namespace Cwiczenie_02_Przeciazanie_operatorow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 2");

            Point p1 = new Point();
            Point p2 = new Point(1, 2);
            Point p3 = new Point();

            p1.x = 3;
            p1.y = 4;

            if (p1)
                Console.WriteLine("P1");
            else
                Console.WriteLine("Nie p1");

            if (p3)
                Console.WriteLine("P3");
            else
                Console.WriteLine("Nie P3");

            p3 = p1 + p2;

            p1.print();
            p2.print();
            p3.print();

            Console.WriteLine(p1 == p3);
            Console.WriteLine(p1 == p1);
            Console.WriteLine(p1 <= p2);
            Console.WriteLine(p1 > p2);

            p3++;
            p3.print();
            p3--;
            p3.print();

            Point p4 = 5;
            p4.print();

            Console.WriteLine((int)p3);

            // Nie jest możliwe nadpisanie operatora +=
        }

        class Point
        {
            public int x;
            public int y;

            public Point(int _x, int _y)
            {
                this.x = _x;
                this.y = _y;
            }

            public Point()
            {
                x = 0;
                y = 0;
            }

            public Point(Point p)
            {
                x = p.x;
                y = p.y;
            }

            public void print()
            {
                Console.WriteLine("X: " + x);
                Console.WriteLine("Y: " + y);
                Console.WriteLine();
            }

            public Point(int _x)
            {
                x = _x;
                y = 0;
            }

            public static Point operator + (Point p1, Point p2)
            {
                return new Point(p1.x + p2.x, p1.y + p2.y);
            }

            public static bool operator true(Point p)
            {
                return p.x != 0 || p.y != 0;
            }

            public static bool operator false(Point p)
            {
                return p.x == 0 && p.y == 0;
            }

            public static bool operator ==(Point p1, Point p2)
            {
                return p1.x == p2.x && p1.y == p2.y;
            }

            public static bool operator !=(Point p1, Point p2)
            {
                return p1.x != p2.x || p1.y != p2.y;
            }

            public override bool Equals(object obj)
            {
                if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                {
                    return false;
                }
                else
                {
                    Point p = (Point)obj;
                    return (x == p.x) && (y == p.y);
                }
            }

            public override int GetHashCode()
            {
                return (x << 2) ^ y;
            }

            public static bool operator <(Point p1, Point p2)
            {
                return p1.x < p2.x && p1.y < p2.y;
            }

            public static bool operator >(Point p1, Point p2)
            {
                return p1.x > p2.x && p1.y > p2.y;
            }

            public static bool operator <=(Point p1, Point p2)
            {
                return p1.x <= p2.x && p1.y <= p2.y;
            }

            public static bool operator >=(Point p1, Point p2)
            {
                return p1.x >= p2.x && p1.y >= p2.y;
            }

            public static Point operator ++(Point p)
            {
                p.x++;
                p.y++;
                return new Point(p);
            }

            public static Point operator --(Point p)
            {
                p.x--;
                p.y--;
                return new Point(p);
            }

            public static implicit operator Point(int n)
            {
                return new Point(n);
            }

            public static explicit operator int(Point p)
            {
                return p.x + p.y;
            }
        }
    }
}
