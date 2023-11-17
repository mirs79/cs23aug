using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PazlMVP
{
    class Model
    {
        String[] state = "X_X_X_ _o_o_o".Split('_');
        
        int emptyPosition = 3;

        public String GetState()
        {
            String S;
            S = String.Join("", state);
            return S;
        }

        public void Move(int move)
        {
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
               throw new ArgumentException(String.Format("Укажите позицию от {0} до {1}, исключая {2}\n", allowedMin, allowedMax, emptyPosition));                
            }
            state[emptyPosition] = state[move];
            state[move] = " ";
            emptyPosition = move;
        }

        public int GetEmptyPosition()
        {
            return emptyPosition;
        }

        public bool IsSolved()
        {
            int i = 0;
            String[] standard = "o_o_o_ _X_X_X".Split('_');
            while (i < state.Length)
            {
                if (!state[i].Equals(standard[i]))
                {
                    return false;                    
                }
                i++;
            }
            return true;
        }
    }
}
