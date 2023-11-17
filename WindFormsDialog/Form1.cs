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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVvod_Click(object sender, EventArgs e)
        {
            Form2 DialogForm = new Form2();
            State StateDialog = new State();
            DialogForm.SetState(StateDialog);
            if (DialogForm.ShowDialog()==DialogResult.OK )
            {
                label1.Text = label1.Text + " " + StateDialog.Value;
            }
        }
    }
}
