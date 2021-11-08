using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var MyContacts = new duckyEntities().Contacts;

            MessageBox.Show($"We have {MyContacts.Count()} contacts");

            foreach (Contact item in MyContacts)
            {
                listBox1.Items.Add(item);
            }
        }
    }

    public partial class Contact
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
