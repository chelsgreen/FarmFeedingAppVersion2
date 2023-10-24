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
    public partial class AnimalSummary : Form
    {
        //attributes or fields
        AnimalManager am;
        private DataTable dt;
        private DataView dv;
        private string iD;

        public AnimalSummary(AnimalManager am)
        {
            this.am = am;
            this.iD = "";

            InitializeComponent();
            animalsumcbx.SelectedIndex = 0;
          
        }
        //Functions

        //when user presses home button
        private void homeBtn_Click(object sender, EventArgs e)
        {
            //takesm user back to home screen
            this.Hide();
            Home myNewForm = new Home(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }


        //returns the values of the summary in the combo box 
        private void animalsumcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbSummary.Text = am.MainSummary(animalsumcbx.Text);
        }
    }
}



