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
        AnimalManger am;
        public Home()
        {
            this.am = am;
            InitializeComponent();
        }
        //Goes to Add Animal Form
       

        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

       
    
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void addAnimalbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddAnimal myNewForm = new AddAnimal(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        //If user selects this then closes the application
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
    }
}
