using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PazlMVP
{
    public class Presenter
    {
        private IView view;
        private Model model;

        public Presenter(IView view)
        {
            this.view = view;
            view.Move += View_Move; /// view.SetPresenter(this); -17.11.23
            view.Begin += View_Begin;
            this.model = new Model();
        }

        public void Start()
        {
            view.Reset();
            view.Show();
        }

        public void View_Move(int index)   ///Move(int index)-17.11.23
        {
            try
            {
                int empty = model.GetEmptyPosition();
                model.Move(index);

                view.Display(empty, "X");

                view.Display(index, " ");

            } catch (ArgumentException ex)
            {
                view.Message(ex.Message);
            }
        }

        public void View_Begin()
        {
            model.Begin();
            view.Reset();
        }
    }
}
