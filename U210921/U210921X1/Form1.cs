using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Vi vill stötta en bilhandlare med ett programstöd för att hantera sina bilar.
Första fasen innehåller följande behov:
Inventarielista bifogas med alla bilar som finns i lager
Se till att hantera det i ditt program avseende domänmodellen (namn på klassen och egenskaper behöver matcha)
När programmet startar vill vi direkt se en lista över alla bilar, sorterat utifrån tillverkare i alfabetisk ordning
Ex: "Audi Q3, 2011" är all info som ska visas i listan när programmet startar
Skapa en listbox till i underkanten, som kan fungera som en "kvittoremsa" för de olika frågorna/funktionerna
1/Knapp som ger svaret på "Amount of red cars" i listboxen ska då visas "You have X red cars"
2/Antal bilar äldre än 2003
3/Antal gråa Volvobilar
4/Snittkörsträckan för BMW bilarna
5/Vilken är den dyraste bilen?
*/

namespace U210921X1
{
    public partial class Form1 : Form
    {
        List<Car> Cars;
        public Form1()
        {
            InitializeComponent();
        }
    }
}

public class Car
{
    public string color { get; set; }
    public string make { get; set; }
    public string mdoel { get; set; }
    public int price { get; set; }
    public int mileage { get; set; }
}