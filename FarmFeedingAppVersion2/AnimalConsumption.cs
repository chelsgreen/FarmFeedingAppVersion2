using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmFeedingAppVersion2
{
    public partial class AnimalConsumption : Form
    {
        AnimalManger am;
        public AnimalConsumption(AnimalManger am)
        {
            this.am = am;
            InitializeComponent();
            Summaryrtbx.Text = am.ConsumptionSummary();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AnimalConsumption_Load(object sender, EventArgs e)
        {

        }

        private void addAnimalbtn_Click(object sender, EventArgs e)
        {
            am.AddAnimalConsumption((int)foodcounternud.Value);

            this.Hide();
            Home myNewForm = new Home(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void day1updown_ValueChanged(object sender, EventArgs e)
        {
            //add funstion so user is unable to enter a null value 
            foodcounternud.Maximum = 25000;
            foodcounternud.Minimum = 0;
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home myNewForm = new Home(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void Summaryrtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsummary_Click(object sender, EventArgs e)
        {
           
        }
    }
}
