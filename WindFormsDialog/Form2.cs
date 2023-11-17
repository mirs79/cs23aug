using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindFormsDialog
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        State SS;

        public void SetState(State S)
        {
            SS = S;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SS.Value = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
