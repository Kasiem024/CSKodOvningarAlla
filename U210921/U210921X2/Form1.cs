﻿using System;
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
        public Form1()
        {
            InitializeComponent();

            Cars = new List<Car>();//Making the list Cars here becasue I now need it
            CarList();//Calling to the method CarList here

            btnEnabler();

            listBoxRefresh();
            cmbRefresh();
        }

        private void listBoxAllCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car SelectedCar = (sender as ListBox).SelectedItem as Car;//ListOfCars is a list because ListBox is the sender
                                                                     //SelectedCar is a Car and the selected item
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
            try
            {
                if (Cars.Select(x => x.Id).Contains(int.Parse(tbxId.Text)) != true)
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

                    ClearAllText(this);
                    btnEnabler();
                    listBoxRefresh();
                    cmbRefresh();
                }
                else
                {
                    MessageBox.Show("ID already exists in list! Choose a diffrent ID for your new car!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error! False input!");
            }
        }
        private void cmbChooseColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCarColors.Items.Clear();

            string selectedColor = (sender as ComboBox).SelectedItem.ToString().ToUpper();

            foreach (Car c in Cars)
            {
                if (c.Color.ToUpper() == selectedColor)
                {
                    listBoxCarColors.Items.Add(c);
                }
            }
        }
        private void btnEditCar_Click(object sender, EventArgs e)
        {
            var SelctedCaredit = Cars.Find(x => x.Id == int.Parse(tbxId.Text));//Finding the car with the same Id as tbxId.Text and converting to an int

            tbxPrice.Text = SelctedCaredit.Price.ToString();
            tbxKm.Text = SelctedCaredit.Km.ToString();
            //Writing in tbxPrice and tbxKm the selected cars price and mileage as a string
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control tbx in this.Controls)
            {
                if (tbx is TextBox)
                {
                    if (tbx.Text == string.Empty)
                    {
                        MessageBox.Show("Error! False input!");
                        return;
                    }
                }
            }

            //Finds the car with same index as whats in tbxId, overwrites that cars Price to whats written in tbxPrice
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
            Cars.RemoveAt(SelectedCar());

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
        }

        public void listBoxRefresh() 
        {
            listBoxAllCars.Items.Clear();

            foreach (Car car in Cars.OrderBy(x => x.Make).ThenBy(y => y.Model).ThenBy(z => z.Year))//Prints all cars in the list into the listbox,
                                                          //OrderBy used here so that the list isnt permanently sorted
            {
                listBoxAllCars.Items.Add(car);
            }
        }
        public void cmbRefresh()
        {
            cmbChooseColors.Items.Clear();
            //Selects all variables in property Color that are distinct

            foreach (var color in Cars.Select(x => x.Color.ToUpper()).Distinct())
            {
                cmbChooseColors.Items.Add($"{color}");
            }
        }

        public void ClearAllText(Control con)
        {
            foreach (Control tbx in con.Controls)
            {
                if (tbx is TextBox)
                {
                    ((TextBox)tbx).Clear();
                }
                else
                {
                    ClearAllText(tbx);
                }
            }
        }
        public void btnEnabler()
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