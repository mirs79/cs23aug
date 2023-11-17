using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String data = txtData.Text;
            String[] arr = data.Split('-');
            try
            {
                int a = Int32.Parse(txtA.Text);
                a = Convert.ToInt32(txtA.Text);
                if (a < 0 || a >= arr.Length)
                {
                    rtxtOut.Text = "Число A должно быть в интервале [0, размер массива)";
                }
                else
                {
                    String result;
                    result = $"В массиве длиной {arr.Length}\nна индексе {a}\n находится элемент со значением \"{arr[a]}'\n\u022B";
                    rtxtOut.Text = result;
                }
            }
            catch (FormatException ex)
            {
                rtxtOut.Text = ex.Message;
            }
            //catch (IndexOutOfRangeException ex)
            //{
            //    rtxtOut.Text = "Число A должно быть в интервале [0, размер массива)";
            //}
            finally
            {
                txtA.Text = "999";
            }

            DateTime
        }
    }
}
