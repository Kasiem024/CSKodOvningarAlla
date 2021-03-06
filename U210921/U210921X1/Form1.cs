using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U210921X1
{
    public partial class Form1 : Form
    {
        List<Car> Cars;//Declaring the car here becasue I dont need it yet
        public Form1()
        {
            InitializeComponent();

            Cars = new List<Car>();//Making the list Cars here becasue I now need it
            CarList();//Calling to the method CarList here

            Cars = Cars.OrderBy(x => x.Make).ToList();//Ordering Cars alphabetically by Make and overwriting the current list with the sorted one 

            foreach (var car in Cars)//This is an easy way to print all cars in the list, should exist another shorter way to do it
            {
                CarListBox.Items.Add($" {car.Make} {car.Model} {car.Year}");
            }
        }
        private void btnRedCars_Click(object sender, EventArgs e)
        {
            int i = Cars.FindAll(x => x.Color.ToUpper() == "RED").Count;//Searches Color for everything RED and counts
            CarListBoxFunction.Items.Add($"There are {i} red cars in storage");
        }

        private void btnCarsOld2003_Click(object sender, EventArgs e)
        {
            int i = Cars.FindAll(x => x.Year < 2003).Count;//Searches Year for everything less than 2003 and counts
            CarListBoxFunction.Items.Add($"There are {i} cars made before 2003 in storage");
        }

        private void btnGreyVolvo_Click(object sender, EventArgs e)
        {
            int i = Cars.FindAll(x => x.Make.ToUpper() == "VOLVO").FindAll(y => y.Color.ToUpper() == "GREY").Count;
            //Searches Make for VOLVO then searches that list for GREY and counts
            CarListBoxFunction.Items.Add($"There are {i} grey Volvos in storage");
        }

        private void btnAvgMileBMW_Click(object sender, EventArgs e)
        {
            try
            {
                double i = Cars.FindAll(x => x.Make.ToUpper() == "BMW").Average(y => y.Km);//Searches Make for BMW then calculates the average value for Km
                CarListBoxFunction.Items.Add($"The avergae mileage for all BMW cars in stroage is {i}");
            }
            catch (Exception)
            {
                MessageBox.Show("There are no BMW cars in storage!");//If there are no BMW cars the program will crash because Average will divide by zero
            }
        }

        private void btnExpCar_Click(object sender, EventArgs e)
        {
            Cars = Cars.OrderByDescending(x => x.Price).ToList();//Orders the list by price in descending order
            CarListBoxFunction.Items.Add($"The most expensive car in storage is {Cars[0].Make} {Cars[0].Model} {Cars[0].Year}");
            //Because I ordered the list by price the first car in the list is the most expensive one
        }
        public void CarList()//Code looks cleaner if all cars are in their own method
        {
            Cars.Add(new Car() { Id = 1, Make = "Volvo", Model = "V70", Color = "White", Km = 1292, Price = 3465, Year = 1998 });
            Cars.Add(new Car() { Id = 31, Make = "Skoda", Model = "Fabia", Color = "Red", Km = 1292, Price = 76556, Year = 2001 });
            Cars.Add(new Car() { Id = 14, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 432, Price = 32001, Year = 2003 });
            Cars.Add(new Car() { Id = 4, Make = "Volvo", Model = "V70", Color = "Red", Km = 1223492, Price = 24512, Year = 1998 });
            Cars.Add(new Car() { Id = 23, Make = "BMW", Model = "735", Color = "Black", Km = 435, Price = 234512, Year = 1999 });
            Cars.Add(new Car() { Id = 234, Make = "Audi", Model = "Q3", Color = "Blue", Km = 345, Price = 334552, Year = 2010 });
            Cars.Add(new Car() { Id = 451, Make = "Volvo", Model = "V40", Color = "Grey", Km = 235235, Price = 535512, Year = 2008 });
            Cars.Add(new Car() { Id = 651, Make = "Volvo", Model = "XC90", Color = "White", Km = 345345, Price = 34510, Year = 2011 });
            Cars.Add(new Car() { Id = 91, Make = "Volvo", Model = "V70", Color = "Red", Km = 345, Price = 4512, Year = 1997 });
            Cars.Add(new Car() { Id = 8001, Make = "Audi", Model = "A3", Color = "White", Km = 123492, Price = 87500, Year = 2001 });
            Cars.Add(new Car() { Id = 631, Make = "Audi", Model = "A8", Color = "Blue", Km = 55342, Price = 55400, Year = 2010 });
            Cars.Add(new Car() { Id = 51, Make = "Volvo", Model = "V40", Color = "Red", Km = 1692, Price = 3465, Year = 1999 });
            Cars.Add(new Car() { Id = 781, Make = "Skoda", Model = "Fabia", Color = "Blue", Km = 1792, Price = 56556, Year = 2000 });
            Cars.Add(new Car() { Id = 144, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 4382, Price = 25001, Year = 2004 });
            Cars.Add(new Car() { Id = 48, Make = "Volvo", Model = "V70", Color = "Red", Km = 12292, Price = 26512, Year = 1997 });
            Cars.Add(new Car() { Id = 912, Make = "BMW", Model = "735", Color = "Black", Km = 4395, Price = 134512, Year = 1960 });
            Cars.Add(new Car() { Id = 2344, Make = "Audi", Model = "Q3", Color = "Grey", Km = 3425, Price = 434552, Year = 2011 });
            Cars.Add(new Car() { Id = 4501, Make = "Volvo", Model = "V40", Color = "Grey", Km = 215235, Price = 435512, Year = 2007 });
            Cars.Add(new Car() { Id = 6051, Make = "Volvo", Model = "XC90", Color = "White", Km = 47345, Price = 134510, Year = 2012 });
            Cars.Add(new Car() { Id = 991, Make = "Volvo", Model = "V70", Color = "Red", Km = 3475, Price = 14512, Year = 1998 });
            Cars.Add(new Car() { Id = 801, Make = "Audi", Model = "A7", Color = "White", Km = 492, Price = 187500, Year = 2002 });
            Cars.Add(new Car() { Id = 6031, Make = "Audi", Model = "A6", Color = "Blue", Km = 553, Price = 55400, Year = 2011 });
        }
    }
}
public class Car
{
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Km { get; set; }
    public int Price { get; set; }
    public int Year { get; set; }
}