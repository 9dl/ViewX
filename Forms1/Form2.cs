using CefSharp.DevTools.Debugger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.URL = textBox1.Text;

            Form1 frm = new Form1();
            if (comboBox1.SelectedIndex == 1) { frm.Size = new Size(966, 530); }
            else if (comboBox1.SelectedIndex == 0) { frm.Size = new Size(1274, 713); }
            else if (comboBox1.SelectedIndex == 3) { frm.Size = new Size(448, 707); }
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("webviewer.cfg"))
            {
                var url = File.ReadAllText("webviewer.cfg");

                Form1.URL = url;

                Form1 frm = new Form1();
                if (comboBox1.SelectedIndex == 1) { frm.Size = new Size(966, 530); }
                else if (comboBox1.SelectedIndex == 0) { frm.Size = new Size(1274, 713); }
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No Saved Site...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("webviewer.cfg", textBox1.Text);
            MessageBox.Show("Saved.");
        }
    }
}