using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllElements
{
    public partial class RAdiobutForm : Form
    {
        public RAdiobutForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                textBox1.Text = radioButton1.Text;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    textBox1.Text = radioButton2.Text;
                }
                else 
                {
                    textBox1.Text =  radioButton3.Text;
                }


            }
        }
    }
}
