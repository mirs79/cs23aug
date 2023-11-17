using System;
using System.Collections.Generic;

namespace Coolections
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            List<int> vvod;
            try
            {
                vvod = Metod(4411);
                Console.WriteLine(String.Join(" ", vvod));
                for (int j = 0; j < 5; j++)
                {
                    X = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Делители числа :");
                    vvod=Metod(X);
                    foreach (int item in vvod) /// перебор всех элементов массива и листа
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine(String.Join(" ",vvod));
                }
            }
            catch (FormatException ex)
            { 
                Console.WriteLine("Введите целочисленное положительное число" );
            }
            
            


        }

        public static List<int> Metod(int A)
        {
            List<int> fragment = new List<int>();
            int  i, x2;
            x2 = A / 2;
            for (i = 1; i <= x2; i++)
            {
                if (A % i == 0) fragment.Add(i);
            }
            fragment.Add(A);
            return fragment;
        }
    }
}
