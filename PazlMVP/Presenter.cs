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
            view.SetPresenter(this);
            this.model = new Model();
        }

        public void Start()
        {
            view.Reset();
            view.Show();
        }

        public void Move(int index)
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
    }
}
