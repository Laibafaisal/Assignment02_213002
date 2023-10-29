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
    public partial class Add : Form
    {
        public static Add instance;
        public Add()
        {
            InitializeComponent();
            instance = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            Form1.myList.Add(x);
            listView1_SelectedIndexChanged(sender, e);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var i in Form1.myList)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
