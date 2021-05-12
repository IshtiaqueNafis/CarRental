using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // do not remove this 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            var customerName = tbCustomerName.Text;
            var dateOut = dtDateRented.Value;
            var dateIn = dtDateReturned.Value;
            var cost = Convert.ToDouble(tbCost.Text);

            var carType = drComboBox.SelectedItem.ToString();
            var isValid = true;
            var errormessage = "";
            if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
            {
                isValid = false;
               errormessage+= "Please enter missing data";
            }

            if (dateOut > dateIn)
            {
                isValid = false;
                errormessage += "date in wrong format";

            }
            if(!isValid)
            {
                MessageBox.Show(errormessage);
            }
            else
            {
                MessageBox.Show($@"Customer Name {customerName}" +
                                $@"Date Got {dateOut}"+
                                $@"Date In {dateOut}"+
                                $@"Date In {dateIn}"+
                                $@"Car Type {carType}"+
                                $@"Cost {cost}");
            }
           
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }

            
              
           
        }
        


        
    }
}