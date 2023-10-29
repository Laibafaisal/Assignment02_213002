using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213002_A2q2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.myList.Contains(int.Parse(textBox1.Text)))
            {
                Form1.myList.Remove(int.Parse(textBox1.Text));
                label2.Text = "Element removed successfully!";
            }
            else
            {
                label2.Text = "The element does not exist in the list.";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
