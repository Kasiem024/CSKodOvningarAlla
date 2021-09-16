using System;
using System.Windows.Forms;

namespace U210916X2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);
            listBox1.Items.Add($"{textBox1.Text}+{textBox2.Text} = {i + j}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);
            listBox1.Items.Add($"{textBox1.Text}+{textBox2.Text} = {i - j}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);
            listBox1.Items.Add($"{textBox1.Text}+{textBox2.Text} = {i * j}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);
            listBox1.Items.Add($"{textBox1.Text}+{textBox2.Text} = {i / j}");
        }
    }
}
