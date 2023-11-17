using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JumpPuzzle
{
    class Puzzle
    {
        String[] state = "X_X_X_ _o_o_o".Split('_');
        int emptyPosition = 3;

        public String GetState()
        {
            String S;           
            S= String.Join("", state);
            return S;
        }

        public int Work(int move)
        {
            bool end = false;
            
            String[] standard = "o_o_o_ _X_X_X".Split('_');
                        
            int allowedMin;
            int allowedMax;
            if (emptyPosition > 1)
            {
                allowedMin = emptyPosition - 2;
            }
            else
            {
                allowedMin = 0;
            }
            if (emptyPosition < 5)
            {
                allowedMax = emptyPosition + 2;
            }
            else
            {
                allowedMax = 6;
            }
            if (move < allowedMin || allowedMax < move || move == emptyPosition)
            {
                Console.WriteLine("Укажите позицию от {0} до {1}, исключая {2}\n", allowedMin, allowedMax, emptyPosition);
                return 1; /// continue;
            }
            state[emptyPosition] = state[move];
            state[move] = " ";
            emptyPosition = move;
            int i = 0;
            bool correct = true;
            while (i < state.Length)
            {
                if (!state[i].Equals(standard[i]))
                {
                    correct = false;
                    break;
                }
                i++;
            }
            if (correct)
            {
                return 0; 
            }
            return 1;
        }
    }
}
