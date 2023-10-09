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
    public partial class AddAnimal : Form
    {
        AnimalManger am;

        public AddAnimal(AnimalManger am)
        {
            this.am = am;
            InitializeComponent();
  
        }


        private void exitAddAnimalbtn_Click(object sender, EventArgs e)
        {
            //Takes user back to the home screen
            this.Hide();
            Home myNewForm = new Home(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void continuebtn_Click(object sender, EventArgs e)
        {
            am.AddAnimalHolder(new AnimalHolder(speciescbx.SelectedIndex, dateTimePicker1.Value));
           
            //Now goes to the AnimalConsumption form 
            this.Hide();
            AnimalConsumption myNewForm = new AnimalConsumption(am,"");
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void speciescbx_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void AddAnimal_Load(object sender, EventArgs e)
        {
            speciescbx.SelectedIndex = 0;
           ;
        }
    }
}
 