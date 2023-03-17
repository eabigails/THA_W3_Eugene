using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takehomew3
{
    public partial class secondwinform : Form
    {
        public static secondwinform instance;
        public Label lb1;
       public Label lb2;
        public secondwinform()
        {
            InitializeComponent();
            instance = this;
            lb1 = label_risult;
            

        }

        private void secondwinform_Load(object sender, EventArgs e)
        {

           
        }

        private void checkBox_term_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_term.Checked)
            {

                button_magic.Enabled = true;
            }
            else if (checkBox_choicestrue.Checked)
            {
                button_magic.Enabled = true;
            }
            else
            {
                button_magic.Enabled = false;
            }
        }

        private void button_magic_Click(object sender, EventArgs e)
        {
            if (radioButton_pink.Checked)
            {
                mainwindowform.instance.BackColor = Color.Pink;
            }
            if (radioButton_khaki.Checked)
            {
                mainwindowform.instance.BackColor = Color.Khaki;
            }
            if (radioButton_blue.Checked)
            {
                mainwindowform.instance.BackColor= Color.Blue;
            }
            if (radioButton_red.Checked)
            {
                mainwindowform.instance.BackColor = Color.Red;

            }
            if (radioButton_gray.Checked)
            {
                mainwindowform.instance.BackColor = Color.Gray;
            }
            if (radioButton_white.Checked)
            {
                mainwindowform.instance.ForeColor = Color.White;
            }
            if (radioButton_green.Checked)
            {
                mainwindowform.instance.ForeColor = Color.Green;
            }
            if (radioButton_yellow.Checked)
            {
                mainwindowform.instance.ForeColor= Color.Yellow;
            }
        }
    }
}
