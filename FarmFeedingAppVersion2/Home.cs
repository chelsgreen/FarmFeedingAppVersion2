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
    public partial class Home : Form
    {
        //attributes or fields
        AnimalManager am;
        public Home(AnimalManager am)
        {
            this.am = am;
            InitializeComponent();
        }
               
        //Functions 

        //closes the application
        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

          
     
        // Opens AddAnimal Form
        private void addAnimalbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddAnimal myNewForm = new AddAnimal(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }


        //If user selects this button the application will then close
        private void exitbtn_Click_1(object sender, EventArgs e)
        {

            System.Windows.Forms.Application.Exit();

        }


        //goes to the Animal Summary Form
        private void registeredAnimalsbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AnimalSummary myNewForm = new AnimalSummary(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
  

        //Takes user to AnimalFinder Form
        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalSearch myNewForm = new AnimalSearch(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();

        }
    }
}
