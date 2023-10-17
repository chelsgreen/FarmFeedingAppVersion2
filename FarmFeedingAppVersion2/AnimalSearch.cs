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
    public partial class AnimalSearch : Form
    {

        private DataTable dt;
        private DataView dv;
        private string iD;


        AnimalManager am;
        public AnimalSearch(AnimalManager am)
        {

            this.am = am;
            this.iD = "";
            InitializeComponent();
            if (tbxSearch.Text == "")
            //If the Search textbox is blank then do the following
            {
                tbxSearch.Focus();
            }
            //Listview Properties
            listvSearch.View = View.Details;
            listvSearch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            listvSearch.Columns.Add("ID", 60);
            listvSearch.Columns.Add("Breed", 60);
            listvSearch.Columns.Add("DOB", 155);
            listvSearch.Columns.Add("Health Status", 120);



            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Breed");
            dt.Columns.Add("DOB");
            dt.Columns.Add("status");

            List<AnimalHolder> animalHolders = this.am.GetAnimals();

            foreach (var animalHolder in animalHolders)
            {
                // Determine the health status based on food consumption
                string healthStatus = GetHealthStatus(animalHolder.GetSpecies(), animalHolder.CalculateWeeklyConsumption(), animalHolder.GetFoodConsumedDaily());


                dt.Rows.Add(animalHolder.GetID(), am.GetAnimal(animalHolder.GetSpecies()), animalHolder.GetDateOfBirth().ToLongDateString(), healthStatus);
            }


            // Getting DataList from Animal Manager

            //Fill Datatable
            dv = new DataView(dt);


            PopulateListView(dv);

        }

      

        private void PopulateListView(DataView dv)
        {
            listvSearch.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                // Create a ListViewItem
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString()); // Display the health status

                // Add the ListViewItem to the ListView
                listvSearch.Items.Add(item);
            }
        }

            private void exitafbtn_Click(object sender, EventArgs e)
        {
            //Goes to home screen
            this.Hide();
            Home myNewForm = new Home(am);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        //This takes the user to the animal consumption screen when they are ready to add consumption to the animal again
        private void updatebtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            AnimalConsumption myNewForm = new AnimalConsumption(am, iD);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }



        private void searchtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void listvSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listvSearch.SelectedItems.Count > 0)
            {
                iD = listvSearch.SelectedItems[0].SubItems[0].Text;
            }
        }


        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Breed Like '%{0}%'", tbxSearch.Text); // Code from https://www.youtube.com/watch?v=cycavkXug5U
            PopulateListView(dv);
        }
        private string GetHealthStatus(int species, float weeklyConsumption, List<float> foodConsumedDaily)
        {
            // Define ranges for healthy consumption based on species
            float minHealthy;
            float maxHealthy;

            if (foodConsumedDaily.Count < 7)
            {
                return "Not Enough Data"; // This display when less than 7 days of data are available because not enough data is there to determine whether the animal is healthy or not
            }

            // Set the ranges for what is classes as healthy for each species healthy 
            switch (species)
            {
                case 0: // Chickens
                    minHealthy = 840; // Minimum healthy for a Chicken
                    maxHealthy = 980; // Maximum healthy for a Chicken
                    break;
                case 1: // Sheep
                    minHealthy = 15890; // Minimum healthy for a Sheep
                    maxHealthy = 22260; // Maximum healthy for a Sheep
                    break;
                case 2: // Pig
                    minHealthy = 3500; // Minimum healthy for a Pig
                    maxHealthy = 5600; // Maximum healthy for a Pig
                    break;
                default:
                    // Handle other species as needed
                    minHealthy = 0;
                    maxHealthy = 0;
                    break;
            }

            // Determine health status
            if (weeklyConsumption >= minHealthy && weeklyConsumption <= maxHealthy)
            {
                return "Healthy";
            }
            else
            {
                return "Unhealthy";
            }
        }





    }
}
    

