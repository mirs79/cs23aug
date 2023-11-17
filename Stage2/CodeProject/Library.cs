using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeProject
{
    class Library
    {
        public static void task1860(String word) // В классе Library реализуйте публичный статический метод task1860
        {
            Console.WriteLine("Мы стремимся к " + word);
        }

        public static void task4140(String firstName, String lastName)
        {
            Console.WriteLine("Меня зовут {0}, {1} {0}", lastName, firstName);
        }

        public static double Task4411(double x1)
        {
            double result;
            result = x1 + 7;
            return result;
        }

        public static double Task3946(int[] num)
        {
            double result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                result = result + num[i];
            }
            return result / num.Length;
        }

        public static int Task4283(char k, char[] data)
        {
            int result = 0;
            foreach (char item in data)
            {
                if (k == item)/// item это текущий элемент массива data
                {
                    result++;
                }
            }
            return result;
        }

        public static bool Task8867(int a, int b, int x)
        {
            bool result = false;
            if ((x > a) && (x < b)) result = true;
            return result;
        }
    }
}
