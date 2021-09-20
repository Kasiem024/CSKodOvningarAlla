﻿using System;
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

            btnPlus.Click += new EventHandler(ButtonHandler);
            btnMinus.Click += new EventHandler(ButtonHandler);
            btnMultiply.Click += new EventHandler(ButtonHandler);
            btnDivide.Click += new EventHandler(ButtonHandler);
            //När knapparna trycks anropas ButtonHanlder, detta gör koden mer effektiv
        }

        private void ButtonHandler(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);
            //Konverterar vad som står till en double så att decimaltal kan användas

            switch ((sender as Button).Text)//Beroende på vad som står i knappen ska en case köras
            {
                case "+":
                    double answer = Engine.Plus(i, j);//Skickar i och j till Calculator, där anropas plus och efter den körs blir svaret till answer
                    Result(i, j, answer, (sender as Button).Text);//Skickar i, j, answer och vad som står på knappen till Result

                    break;

                case "-":
                    answer = Engine.Minus(i, j);
                    Result(i, j, answer, (sender as Button).Text);

                    break;
                case "*":
                    answer = Engine.Multiply(i, j);
                    Result(i, j, answer, (sender as Button).Text);

                    break;
                case "/":
                    if (textBox1.Text == "0" || textBox2.Text == "0")
                    {
                        listBox1.Items.Add("Cannot divide by 0");
                    }
                    else
                    {
                        answer = Engine.Divide(i, j);
                        Result(i, j, answer, (sender as Button).Text);
                    }

                    break;
            }
        }

        /*private void btnPlus_Click(object sender, EventArgs e)
        {
            //textboxen förväntar sig en string så måste ändra det till en double först
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = Engine.Plus(i, j);//Skickar i och j till Calculator, vad som händer i Calculator matas in i answer

            Result(i, j, answer, (sender as Button).Text);//Skickar allting inom parentesen till Result klassen
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = Engine.Minus(i, j);

            Result(i, j, answer, (sender as Button).Text);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = Engine.Multiply(i, j);

            Result(i, j, answer, (sender as Button).Text);
        }

        private void btnDivide_Click(object sender, System.EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);

            double answer = Engine.Divide(i, j);

            Result(i, j, answer, (sender as Button).Text);
        }*/
        private void Result(double i, double j, double answer, string operation)
        {
            listBox1.Items.Add($"{i} {operation} {j} = {answer}");//Här skrivs ut allting. operation får man från btn.Text
        }
    }
}