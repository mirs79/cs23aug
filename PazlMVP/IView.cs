using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PazlMVP
{
   public  interface IView
    {
        void Show();
        void Reset();
        void Display(int i, String state);
        void Message(String message);

        void SetPresenter(Presenter p);
    }
}
