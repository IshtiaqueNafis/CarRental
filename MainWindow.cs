using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addRentalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddRentalRecord {MdiParent = this}; // add rental reciord is the parent
            addRentalRecord.Show();
        }
    }
}
