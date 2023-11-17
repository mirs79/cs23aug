using System;
using System.Collections.Generic;

namespace Exmp
{
    class Program
    {
        static void Main(string[] args)

        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            while (true)
            {
                String Str = Console.ReadLine();
                int val = Int32.Parse(Console.ReadLine());
                if(dict.ContainsKey(Str))
                { dict.Remove(Str); }
                    
                dict.Add(Str,val);
                foreach (var item in dict) /// перебор всех элементов массива и листа
                {
                    Console.WriteLine(item.Key + " "+ item.Value);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
