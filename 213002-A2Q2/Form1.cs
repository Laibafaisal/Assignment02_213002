using System.Windows.Forms;

namespace _213002_A2q2
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public static List<int> myList = new List<int>() { 10, 20, 30, 30, 50 };
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add form = new Add();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            obj.Show();
        }
    }
}