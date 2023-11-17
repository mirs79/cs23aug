using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsRead
{
    public partial class Form1 : Form
    {
        // List<String> lst = new List<string>();                        
        List<Composer> lst = new List<Composer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text files(*.txt)|*.txt|Все файлы (*.*)|*.*";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.FileName;
                String patch = dlg.FileName;
                var fileStream = dlg.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                   while(!reader.EndOfStream)
                    {
                        String line = reader.ReadLine();
                        String[] arr = line.Split(';');
                        Composer c = new Composer();
                        c.composer_id = arr[0];
                        c.last_name = arr[2];
                        c.death_date = arr[5];
                        c.death_place = arr[6];
                        lst.Add(c);

                        // lst.Add(arr[0]+ arr[1]+ arr[2]+ arr[3]);
                    }
                    listBox1.DataSource = lst;


                }
            }
        }
    }
}
