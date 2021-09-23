using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
If the inputed Id doesnt match a car in the list
If tbxPrice and tbxKm is empty when btnSave is clicked
If tbxId is empty when btnSave is clicked
If tbxEdit is empty when tbnEdit is clicked
Can write into cmbChooseColors which is unnecessary
Code for btnEdit_Click can probably be better
Design is lacking
*/

namespace U210921X2
{
    public partial class Form1 : Form
    {
        List<Car> Cars;
        public Form1()
        {
            InitializeComponent();

            Cars = new List<Car>();//Making the list Cars here becasue I now need it
            CarList();//Calling to the method CarList here

            listBoxRefresh();

            var CarColors = Cars.Select(x => x.Color).Distinct();//Selects all variables in property Color that are distinct

            foreach (var color in CarColors)
            {
                cmbChooseColors.Items.Add($"{color}");
            }

        }

        private void listBoxAllCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car SelectedCar = (sender as ListBox).SelectedItem as Car;//ListOfCars is a list because ListBox is the sender
                                                                     //SelectedCar is a Car and the selected item
            tbxId.Text = ($"{SelectedCar.Id}");
            tbxMake.Text = ($"{SelectedCar.Make}");
            tbxModel.Text = ($"{SelectedCar.Model}");
            tbxColor.Text = ($"{SelectedCar.Color}");
            tbxKm.Text = ($"{SelectedCar.Km} km");
            tbxPrice.Text = ($"{SelectedCar.Price} kr");
            tbxYear.Text = ($"{SelectedCar.Year}");
        }
        private void cmbChooseColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCarColors.Items.Clear();

            ComboBox ComboBoxColors = (sender as ComboBox).SelectedItem as ComboBox;

            string SelectedColor = (sender as ComboBox).SelectedItem.ToString();

            var AllCarsColor = Cars.FindAll(x => x.Color == SelectedColor);//AllCarsColor is a sublist of Cars

            foreach (var car in AllCarsColor)
            {
                listBoxCarColors.Items.Add(car);
            }
        }
        private void btnEditCar_Click(object sender, EventArgs e)
        {
            var SelctedCarEdit = Cars.Find(x => x.Id == int.Parse(tbxId.Text));//Finding the car with the same Id as tbxId.Text and converting to an int

            tbxPrice.Text = SelctedCarEdit.Price.ToString();
            tbxKm.Text = SelctedCarEdit.Km.ToString();
            //Writing in tbxPrice and tbxKm the selected cars price and mileage as a string
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cars.Find(x => x.Id == int.Parse(tbxId.Text)).Price = int.Parse(tbxPrice.Text);
            //Finds the car with same Id as whats in tbxId, overwrites that cars Price to whats written in tbxPrice

            Cars.Find(x => x.Id == int.Parse(tbxId.Text)).Km = int.Parse(tbxKm.Text);
        }

        private void tbnDelete_Click(object sender, EventArgs e)
        {
            Cars.RemoveAt(SelectedCar());
            listBoxRefresh();
            ClearAllText(this);
        }

        public int SelectedCar()
        {
            return Cars.FindIndex(x => x.Id == int.Parse(tbxId.Text));
        }

        public void listBoxRefresh() 
        {
            listBoxAllCars.Items.Clear();

            foreach (Car car in Cars.OrderBy(x => x.Make))//Prints all cars in the list into the listbox,
                                                          //OrderBy used here so that the list isnt permanently sorted
            {
                listBoxAllCars.Items.Add(car);
            }
        }
        public void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
        public void CarList()//For better visual clarity in the code
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