using System;
using System.Collections.Generic;

namespace ExamplSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            HashSet<string> vvod = new HashSet<string>();
            while (true)
            {
                String Str = Console.ReadLine();
                vvod.Add(Str);
                foreach (String item in vvod) /// перебор всех элементов массива и листа
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
