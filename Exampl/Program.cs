using System;
using System.Collections.Generic;

namespace Exampl
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            
            List<string> vvod = new List<string>();
            while(true)
            {
                String Str = Console.ReadLine();
                vvod.Add(Str);
                foreach(String item in vvod) /// перебор всех элементов массива и листа
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

       public static List<string> NameMetod()
        {
            List<string> fragment = new List<string>();
            return fragment;
        }
    }
}
