using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PazlMVP
{
    // public partial class View : Form  
    //+ интерфейс IView + методы Reset,Display,Messag
    public partial class View : Form,IView
    {
        Button[] buttons;
        Presenter presenter;

        public View()
        {
            InitializeComponent();
            buttons = new Button[] {
                    button1,button2,button3,button4,button5,button6,button7 
            };
        }

        public void  SetPresenter(Presenter p)
        {
            this.presenter = p;
        }

        public void Reset()
        {
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.White;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
        }

        public void Display(int i, String state)
        {
            if (state == "X")
            { buttons[i].BackColor = Color.Black; }
            else if (state == "O")
            { buttons[i].BackColor = Color.Red; }
            else  buttons[i].BackColor = Color.White;
        }

        public void Message(String message)
        {
            label1.Text = message;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            presenter.Move(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            presenter.Move(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            presenter.Move(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            presenter.Move(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            presenter.Move(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            presenter.Move(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            presenter.Move(6);
        }
    }
}
