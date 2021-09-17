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

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);
            listBox1.Items.Add($"{textBox1.Text}+{textBox2.Text} = {i + j}");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);
            listBox1.Items.Add($"{textBox1.Text}-{textBox2.Text} = {i - j}");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);
            listBox1.Items.Add($"{textBox1.Text}*{textBox2.Text} = {i * j}");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);
            listBox1.Items.Add($"{textBox1.Text}/{textBox2.Text} = {i / j}");
        }
    }
}