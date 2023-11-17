using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JumpPuzzle
{
    class Program
    {
        char[] data = new char[] { 'x', 'x', 'x', ' ', 'o', 'o', 'o' };
        String Num = "0123456";
        int Probel=2, NewPoz=0;

        public static void Vivod()
        {
            Console.WriteLine(data);
            Console.WriteLine(Num);
        }
        public static void VivErr()
        {
            Console.WriteLine("Введите число от 0 до 6 исключая " + Probel);
            Vivod();
        }

        public static bool VvodNewPoz()
        {
            bool result = false;
            int value;
            try
            {
                value = Int32.Parse(Console.ReadLine());
                if (value > -1 && value < 7 && value != Probel) 
                { NewPoz = value;
                  result = true;  
                }
                else { VivErr(); }
            }
            catch   { VivErr(); }
            return result;
        }


        static void Main(string[] args)
        {
            Vivod();
            if (VvodNewPoz())
            {

                Vivod();
            }
        }
       
        

    }
}
