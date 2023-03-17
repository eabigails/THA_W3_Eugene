using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace takehomew3
{
    public partial class mainwindowform : Form
    {
        public static mainwindowform instance;
        public TextBox tb1;
        public TextBox tb2;
        public mainwindowform()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox_name;
            tb2 = textBox_favartist;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string is1 = "Please fill in with the correct input";
            if (textBox_name.Text == "")
            {
                
                MessageBox.Show(is1, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           if (textBox_favartist.Text == "")
            {
                MessageBox.Show(is1, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox_true_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_true.Checked)
            {
                button_submit.Enabled = true;
                button_newform.Enabled = true;
            }
            else 
            {
                button_submit.Enabled = false;
                button_newform.Enabled= false;
            }
        }

        private void button_newform_Click(object sender, EventArgs e)
        {
            secondwinform form = new secondwinform();
            form.Show();
            string isiii = "Hi, my name is " + textBox_name.Text + " and my favorite artist is " + textBox_favartist.Text;
            secondwinform.instance.lb1.Text = isiii;
           


        }
        
    }
}
