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
Design is lacking
*/

namespace U210921X2
{
    public partial class Form1 : Form
    {
        List<Car> Cars;
        //Decalring that I want to usa a list called Cars that has properties from the class Car in the future
        public Form1()
        {
            InitializeComponent();

            Cars = new List<Car>();//Making the list Cars here becasue I now need it
            CarList();//Calling to the method CarList here

            btnEnabler();//Disables tbxId and btnAdd because theyre on by deafult
            listBoxRefresh();//Adds all items in list Cars to listBoxAllCars
            cmbRefresh();//Adds all distinct properties in Car to cmbChooseProperty
        }

        private void listBoxAllCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car SelectedCar = (sender as ListBox).SelectedItem as Car;
            //SelectedCar is the currently selected item in listbox listBoxAllCars and is a Car

            tbxId.Text = $"{SelectedCar.Id}";
            tbxMake.Text = $"{SelectedCar.Make}";
            tbxModel.Text = $"{SelectedCar.Model}";
            tbxColor.Text = $"{SelectedCar.Color}";
            tbxKm.Text = $"{SelectedCar.Km}";
            tbxPrice.Text = $"{SelectedCar.Price}";
            tbxYear.Text = $"{SelectedCar.Year}";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try//This part of the program is whats intended to happen if nothing wrong happens
            {
                if (Cars.Select(x => x.Id).Contains(int.Parse(tbxId.Text)) != true)
                    //If the ID in tbx.Id doesnt overlap with a car in Cars
                {
                    Cars.Add(new Car()
                    {
                        Id = int.Parse(tbxId.Text),
                        Make = tbxMake.Text.ToUpper(),
                        Model = tbxModel.Text.ToUpper(),
                        Color = tbxColor.Text.ToUpper(),
                        Km = int.Parse(tbxKm.Text),
                        Price = int.Parse(tbxPrice.Text),
                        Year = int.Parse(tbxYear.Text)
                    });

                    ClearAllText(this);//All textboxes are cleared for better user experience.
                                       //"this" points to the class its located in
                    btnEnabler();
                    listBoxRefresh();
                    cmbRefresh();
                }
                else
                {
                    MessageBox.Show("ID already exists in list! Choose a diffrent ID for your new car!");
                }
            }
            catch (Exception)//If something not intended happens when btnAdd is clicked this happens
            {
                MessageBox.Show("Error! False input!");
            }
        }
        private void cmbChooseProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCarProperty.Items.Clear();//Clears what is currently in listBoxCarProperty for visual clarity

            string selectedProperty = (sender as ComboBox).SelectedItem.ToString();
            //SelectedPropertyis the selected item from the ComboBox cmbChooseProperty and is also a string

            foreach (Car c in Cars)//Looks through all items in Cars
            {
                if (c.Make.ToUpper() == selectedProperty)
                //If the property of the Car that is currently being examined matches selectedProperty add that Car to listBoxCarProperty
                {
                    listBoxCarProperty.Items.Add(c);
                }
                if (c.Model.ToUpper() == selectedProperty)
                {
                    listBoxCarProperty.Items.Add(c);
                }
                if (c.Color.ToUpper() == selectedProperty)
                {
                    listBoxCarProperty.Items.Add(c);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control tbx in Controls)
                //For each component in the visual design in Form1 that is included in the Control class
            {
                if (tbx is TextBox)//If the Control is a TextBox
                {
                    if (tbx.Text == string.Empty)//If the TextBox is empty
                    {
                        MessageBox.Show("Error! False input!");
                        return;//Exits out of the current event method
                    }
                }
            }

            Cars[SelectedCar()].Make = tbxMake.Text.ToUpper();
            Cars[SelectedCar()].Model = tbxModel.Text.ToUpper();
            Cars[SelectedCar()].Color = tbxColor.Text.ToUpper();
            Cars[SelectedCar()].Price = int.Parse(tbxPrice.Text);
            Cars[SelectedCar()].Km = int.Parse(tbxKm.Text);
            Cars[SelectedCar()].Year = int.Parse(tbxYear.Text);

            listBoxRefresh();
            ClearAllText(this);
            cmbRefresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Cars.RemoveAt(SelectedCar());//Removes the Car with the same index as whats in tbxId

            listBoxRefresh();
            ClearAllText(this);
            cmbRefresh();
        }
        private void btnNewCar_Click(object sender, EventArgs e)
        {
            btnEnabler();
            listBoxRefresh();
            ClearAllText(this);
            cmbRefresh();
        }

        public int SelectedCar()
        {
            return Cars.FindIndex(x => x.Id == int.Parse(tbxId.Text));
            //Finds the index of the Car with the same Id as whats currently in tbxId
        }

        public void listBoxRefresh()
        //Method that refreshes the listBox listBoxAllCars. Makin a method because listBoxAllCars regularly gets changed
        {
            listBoxAllCars.Items.Clear();//Clears all items in listbox before updating it

            foreach (Car car in Cars.OrderBy(x => x.Make).ThenBy(y => y.Model).ThenBy(z => z.Year))
                //Adds all cars in the list into the listbox. OrderBy used here so that the list isnt permanently sorted
                //First OrderBy lists by property Make, ThenBy sorts by Model property then sorts by year Property
                //Purpose of the sorting is better visual clarity
            {
                listBoxAllCars.Items.Add(car);
            }
        }
        public void cmbRefresh()
        {
            cmbChooseProperty.Items.Clear();

            foreach (var item in Cars.Select(x => x.Make.ToUpper()).Distinct())
            //Selects all variables in property Make that are distinct

            {
                cmbChooseProperty.Items.Add($"{item}");//Adds all distinct makes to cmbChooseProperty
            }

            foreach (var item in Cars.Select(x => x.Model.ToUpper()).Distinct())
            {
                cmbChooseProperty.Items.Add($"{item}");
            }

            foreach (var item in Cars.Select(x => x.Color.ToUpper()).Distinct())
            {
                cmbChooseProperty.Items.Add($"{item}");
            }
        }

        public void ClearAllText(Control con)
            //Purpose of this method is to clear all textboxes, creating a method because textboxes need to be cleared regularly
        {
            foreach (Control tbx in Controls)//Need to understand the pupose of "con" here
            {
                if (tbx is TextBox)//If the Control is a textBox clear it
                {
                    ((TextBox)tbx).Clear();
                }
                //else
                //{
                //    ClearAllText(tbx);
                //}
                //If a textBox is nested inside another type of control it is also cleared
                //Unnecessary in this program
            }
        }
        public void btnEnabler()
            //Purpose of this method is to reverse usability of tbxId and btnAdd
            //Because theyre not always needed
        {
            if (tbxId.Enabled == false)
            {
                tbxId.Enabled = true;
            }
            else
            {
                tbxId.Enabled = false;
            }

            if (btnAdd.Enabled == false)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
        public void CarList()//For better visual clarity in the code
        {
            Cars.Add(new Car() { Id = 1, Make = "VOLVO", Model = "V70", Color = "WHITE", Km = 1292, Price = 3465, Year = 1998 });
            Cars.Add(new Car() { Id = 31, Make = "SKODA", Model = "FABIA", Color = "RED", Km = 1292, Price = 76556, Year = 2001 });
            Cars.Add(new Car() { Id = 14, Make = "VOLVO", Model = "XC90", Color = "BLUE", Km = 432, Price = 32001, Year = 2003 });
            Cars.Add(new Car() { Id = 4, Make = "VOLVO", Model = "V70", Color = "RED", Km = 1223492, Price = 24512, Year = 1998 });
            Cars.Add(new Car() { Id = 23, Make = "BMW", Model = "735", Color = "BLACK", Km = 435, Price = 234512, Year = 1999 });
            Cars.Add(new Car() { Id = 234, Make = "AUDI", Model = "Q3", Color = "BLUE", Km = 345, Price = 334552, Year = 2010 });
            Cars.Add(new Car() { Id = 451, Make = "VOLVO", Model = "V40", Color = "GREY", Km = 235235, Price = 535512, Year = 2008 });
            Cars.Add(new Car() { Id = 651, Make = "VOLVO", Model = "XC90", Color = "WHITE", Km = 345345, Price = 34510, Year = 2011 });
            Cars.Add(new Car() { Id = 91, Make = "VOLVO", Model = "V70", Color = "RED", Km = 345, Price = 4512, Year = 1997 });
            Cars.Add(new Car() { Id = 8001, Make = "AUDI", Model = "A3", Color = "WHITE", Km = 123492, Price = 87500, Year = 2001 });
            Cars.Add(new Car() { Id = 631, Make = "AUDI", Model = "A8", Color = "BLUE", Km = 55342, Price = 55400, Year = 2010 });
            Cars.Add(new Car() { Id = 51, Make = "VOLVO", Model = "V40", Color = "RED", Km = 1692, Price = 3465, Year = 1999 });
            Cars.Add(new Car() { Id = 781, Make = "SKODA", Model = "FABIA", Color = "BLUE", Km = 1792, Price = 56556, Year = 2000 });
            Cars.Add(new Car() { Id = 144, Make = "VOLVO", Model = "XC90", Color = "BLUE", Km = 4382, Price = 25001, Year = 2004 });
            Cars.Add(new Car() { Id = 48, Make = "VOLVO", Model = "V70", Color = "RED", Km = 12292, Price = 26512, Year = 1997 });
            Cars.Add(new Car() { Id = 912, Make = "BMW", Model = "735", Color = "BLACK", Km = 4395, Price = 134512, Year = 1960 });
            Cars.Add(new Car() { Id = 2344, Make = "AUDI", Model = "Q3", Color = "GREY", Km = 3425, Price = 434552, Year = 2011 });
            Cars.Add(new Car() { Id = 4501, Make = "VOLVO", Model = "V40", Color = "GREY", Km = 215235, Price = 435512, Year = 2007 });
            Cars.Add(new Car() { Id = 6051, Make = "VOLVO", Model = "XC90", Color = "WHITE", Km = 47345, Price = 134510, Year = 2012 });
            Cars.Add(new Car() { Id = 991, Make = "VOLVO", Model = "V70", Color = "RED", Km = 3475, Price = 14512, Year = 1998 });
            Cars.Add(new Car() { Id = 801, Make = "AUDI", Model = "A7", Color = "WHITE", Km = 492, Price = 187500, Year = 2002 });
            Cars.Add(new Car() { Id = 6031, Make = "AUDI", Model = "A6", Color = "BLUE", Km = 553, Price = 55400, Year = 2011 });
        }
    }
}