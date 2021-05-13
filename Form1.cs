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
using CarRental.Models;

namespace CarRental
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext _caRentalEntities;
        public Form1()
        {
            InitializeComponent(); // do not remove this 
            _caRentalEntities = new ApplicationDbContext();
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
            if(isValid)
            {
                var rentalRecord = new CarRentals
                {
                    CustomerName = customerName, DateRented = dateOut, DateReturned = dateIn, Cost =(decimal)cost,
                    CarTypeId =(int)drComboBox.SelectedValue
                };
                _caRentalEntities.CarRentals.Add(rentalRecord);
                _caRentalEntities.SaveChanges();
                MessageBox.Show($@"Customer Name {customerName}" +
                                $@"Date Got {dateOut}" +
                                $@"Date In {dateOut}" +
                                $@"Date In {dateIn}" +
                                $@"Car Type {carType}" +
                                $@"Cost {cost}");
                }
            else
            {
                MessageBox.Show(errormessage);
               
            }
           
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }

            
              
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = _caRentalEntities.CarTypes.ToList(); // this gets the car from the database. 
            drComboBox.DisplayMember = "Name"; // set the property name 
            drComboBox.ValueMember = "Id"; // set the id 
            drComboBox.DataSource = cars; // cars 
        }
    }
}