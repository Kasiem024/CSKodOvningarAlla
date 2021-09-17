using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U210916X3
{
    public class Calculator//Det är här kalkulationen faktiskt händer
    {
        public double Plus(double number1, double number2)//i och j blir till number1 och number2
        {
            return number1 + number2;//return skickas tillbaka till vart den skickades ifrån.
        }
        public double Minus(double number1, double number2)
        {
            return number1 - number2;
        }
        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
        public double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}