using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.task1860("знаниям");
            Library.task1860("цели");
            Library.task1860("результатам");

            Library.task4140("Джеймс", "Бонд");
            Library.task4140("капитан", "Джек Воробей");
            double r;
            r= Library.Task4411(11.13);            
            Console.WriteLine("{0:F4}",r);

            r = Library.Task4411(-7919);
            Console.WriteLine("{0:F4}", r);

            int[] num1 = new int[] { 9, 8, 9, 1, 1, 5, 1, 1 };
            r = Library.Task3946(num1);
            Console.WriteLine("{0:F4}", r);

            char[] data1 = new char[] { 'q', 'w', 'e', 'r', 'q', 'w' };
            Console.WriteLine(Library.Task4283('e',data1 ));

            bool rrr = Library.Task8867(1, 3, 2);
            if (rrr) { Console.WriteLine("в пределах"); }
            else { Console.WriteLine("не в пределах"); }

            Console.WriteLine("--------------29.09.23-----------");

            Point src = new Point();
            src.x = 1;
            src.y = 1;
            Point dest = new Point();
            dest.x = 3;
            dest.y = 4;
            double dist = Point.distanceBetween(src, dest);
            Console.WriteLine(Point.print(src));
            Console.WriteLine(Point.print(dest));
            Console.WriteLine("Расстояние между точками равно {0:F4}", dist);

            dist = src.distanceTo(dest);
            Console.WriteLine("Расстояние между точками равно {0:F4}", dist);
        }

       
    }
}
