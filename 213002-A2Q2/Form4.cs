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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.myList.Contains(int.Parse(textBox1.Text)))
            {
                int x = Form1.myList.BinarySearch(int.Parse(textBox1.Text));
                label2.Text = $"The element exists at the index {x}.";
            }
        }
    }
}
