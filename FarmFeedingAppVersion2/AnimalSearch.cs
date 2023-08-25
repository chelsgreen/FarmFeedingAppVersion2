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

        AnimalManger am;
        public AnimalSearch(AnimalManger am)
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

            listvSearch.Columns.Add("ID",60);
            listvSearch.Columns.Add("Breed",60);
            listvSearch.Columns.Add("DOB",155);
            
           

            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Breed");
            dt.Columns.Add("DOB");



            // Getting DataList from Animal Manager
            List<AnimalHolder> animalHolders = this.am.GetAnimals();

            foreach (var animalHolder in animalHolders)   
            {

                dt.Rows.Add(animalHolder.GetID(),am.GetAnimal(animalHolder.GetSpecies()),animalHolder.GetDateOfBirth().ToLongDateString());

            }
            //Fill Datatable
            dv = new DataView(dt);


            PopulateListView(dv);

        }

        private void PopulateListView(DataView dv)
        {
            listvSearch.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listvSearch.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString()  }));
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
           AnimalConsumption myNewForm = new AnimalConsumption(am,iD);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }



        private void searchtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void listvSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            iD = listvSearch.Items[0].Text;
            
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Breed Like '%{0}%'", tbxSearch.Text); // Code from https://www.youtube.com/watch?v=cycavkXug5U
            PopulateListView(dv);
        }
    }
}
