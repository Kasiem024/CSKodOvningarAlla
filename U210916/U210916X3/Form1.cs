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

            btnPlus.Click += new EventHandler(ButtonHandler);
            btnMinus.Click += new EventHandler(ButtonHandler);
            btnMultiply.Click += new EventHandler(ButtonHandler);
            btnDivide.Click += new EventHandler(ButtonHandler);
            //När knapparna trycks anropas ButtonHanlder, detta gör koden mer effektiv

            textBox1.KeyPress += new KeyPressEventHandler(KeyControl);
            textBox2.KeyPress += new KeyPressEventHandler(KeyControl);
            //När en knapp trycks i textBoxen
        }

        private void KeyControl(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')//Om knappen som trycks inte är mellan 0 och 9 kan den inte tryckas
            {
                if (((short)e.KeyChar) != 8)//Backspace har nummret 8 i ASCII, alltså kan man trycka backspace,
                                            //skriver short så att programmer förstår att jag menar ACSII, kan lika väl skriva int
                {
                    e.Handled = true;//Kan stå false här och man kan ändå använda backspace, förstår inte varför
                }
            }
        }

        private void ButtonHandler(object sender, EventArgs e)
        {
            double i = double.Parse(textBox1.Text);
            double j = double.Parse(textBox2.Text);
            double answer = 0;//Skapar answer innan switch så att den kan användas efter
            //Konverterar vad som står till en double så att decimaltal kan användas

            switch ((sender as Button).Text)//Beroende på vad som står i knappen ska en case köras
            {
                case "+":
                    answer = Engine.Plus(i, j);//Skickar i och j till Calculator, där anropas Plus och efter den körs blir svaret till answer

                    break;

                case "-":
                    answer = Engine.Minus(i, j);

                    break;
                case "*":
                    answer = Engine.Multiply(i, j);

                    break;
                case "/":
                    if (textBox2.Text == "0")//Ifall man försöker dela med 0. Något att tänka på för framtiden är att hantera undantag i en annan fil,
                                             //i detta fall kanske detta borde hanteras i Calculator
                    {
                        listBox1.Items.Add("Cannot divide by 0");
                        return;//Avslutar hela metoden
                    }
                    else
                    {
                        answer = Engine.Divide(i, j);

                        break;
                    }
                    //Använder inte try catch här för att double kan vara ett oändligt tal, alltså funkar inte DivideByZeroException
            }

            Result(i, j, answer, (sender as Button).Text);//Skickar i, j, answer och vad som står på knappen till Result

        }

        //Använde denna kod i förra delen av uppgiften men blev ineffektiv
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

        private void Result(double i, double j, double answer, string operation)//Operation får värdet av (sender as Button).text
        {
            listBox1.Items.Add($"{i} {operation} {j} = {answer}");//Här skrivs allting ut till listBox1
        }
    }
}