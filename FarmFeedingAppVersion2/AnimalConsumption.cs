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
            // Goes back to previous form
            this.Hide();
            AddAnimal myNewForm = new AddAnimal(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }


        //Adds the Consumption to the animal then takes user back to home screen
        private void addAnimalbtn_Click(object sender, EventArgs e)
        {
            am.AddAnimalConsumption((int)foodcounternud.Value);
            Summaryrtbx.Text= am.ConsumptionSummary();           
            this.Hide();
            Home myNewForm = new Home(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }


        private void day1updown_ValueChanged(object sender, EventArgs e)
        {
            //function so that the user is unable to enter a null value *Change Later*
            foodcounternud.Maximum = 30000;
            foodcounternud.Minimum = 0;
            
        }


        //Takes user back to home form
        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home myNewForm = new Home(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }            
    }
}
