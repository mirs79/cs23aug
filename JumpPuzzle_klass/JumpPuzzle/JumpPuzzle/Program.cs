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
            while (true) //бесконечный цикл
            {
                Console.WriteLine(P.GetState());
                Console.WriteLine("0123456");

                int move1 = Int32.Parse(Console.ReadLine());
                
                if (P.Work(move1) == 0) break;
                

            }
            Console.WriteLine(P.GetState());
            Console.WriteLine("0123456");

        }



    }
}
