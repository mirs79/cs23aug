using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JumpPuzzle
{
    class Program
    {

        static void Main(string[] args)
        {
                        
            int emptyPosition = 3;
            Puzzle P = new Puzzle();
           // while (true) //бесконечный цикл
           // {
                Console.WriteLine(P.GetState());
                Console.WriteLine("0123456");


            P.Work(1);
            Console.WriteLine(P.GetState());
            Console.WriteLine("0123456");
            P.Work(2);
            Console.WriteLine(P.GetState());
            Console.WriteLine("0123456");
            P.Work(3);
            Console.WriteLine(P.GetState());
            Console.WriteLine("0123456");

            //}
            //  Console.WriteLine(P.GetState());
            //   Console.WriteLine("0123456");

        }



    }
}
