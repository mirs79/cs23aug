using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PazlMVP
{
    public delegate void PuzzleEventHandler(int index);
    public delegate void PuzzleResetEventHandler();

    public  interface IView
    {
        void Show();
        void Reset();
        void Display(int i, String state);
        void Message(String message);

        event PuzzleEventHandler Move;  // +17.11.23
        // void SetPresenter(Presenter p); -17.11.23
        event PuzzleResetEventHandler Begin;
    }
    
}
