using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U210916X3
{
    public partial class Form1 : Form
    {
        Calculator Engine = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }
        public void btnPlus_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = Engine.Plus(i, j);

            Result(i, j, answer, (sender as Button).Text);
        }

        public void btnMinus_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = Engine.Minus(i, j);

            Result(i, j, answer, (sender as Button).Text);
        }

        public void btnMultiply_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = Engine.Multiply(i, j);

            Result(i, j, answer, (sender as Button).Text);
        }

        public void btnDivide_Click(object sender, System.EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = Engine.Divide(i, j);

            Result(i, j, answer, (sender as Button).Text);
        }
        public void Result(double i, double j, double answer, string operation)
        {
            listBox1.Items.Add($"{i} {operation} {j} = {answer}");
        }
    }
}