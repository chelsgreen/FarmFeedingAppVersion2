using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeedingAppVersion2
{
    public class AnimalHolder
    {
        //attributes or fields
        private int species;
        private bool statusOfAnimal;
        private DateTime dateOfBirth;
        private int foodConsumed;
        int speciescounter = 1;
        private List<float> foodConsumedDaily;
        private string iD;
        private DateTime dateTime;       
        private List<float> foodPrices = new List<float>() { 0.00165f, 54.5f, 43f };
        //methods and functions



        //constructs an animal holder object
        public AnimalHolder(int species, DateTime dateOfBirth)


        {
            //this.species = species;
            this.species = species;
            this.dateOfBirth = dateOfBirth;

            //set bool of statusOfAnimal to true
            statusOfAnimal = true;

            //initilise foodConsumedDaily List
            foodConsumedDaily = new List<float>();

            

          
        }
        public void AddAnimalConsumption(int dailyConsumption)
        {

            foodConsumedDaily.Add(dailyConsumption);
        }


        public int GetSpecies()
        {           
            return species;
        }

        public DateTime GetDateOfBirth()
        {
            return dateOfBirth;
        }

        public string GetID()
        {
            return iD;
        }


        public float CalculateTotalCost(float costPerKg)
        {
            // calculate cost per kg




            //time cost per kg by animals weekly consumption
            return CalculateWeeklyConsumption() * costPerKg;
            Console.WriteLine();
        }





        public float CalculateWeeklyConsumption()
        {


            float sumConsumption = 0;
            //calculate the last 7 days of food consumption

            //add each daily consumption to sum consumption varilable
            for (int dailyConsumptionIndex = foodConsumedDaily.Count - 1; dailyConsumptionIndex > foodConsumedDaily.Count - 8; dailyConsumptionIndex--)
            {
                sumConsumption += foodConsumedDaily[dailyConsumptionIndex];
            }




            //return total weekly consumtion

            return sumConsumption;
        }

        private float costOfFood(float price)
        {


            return CalculateWeeklyConsumption() * price;
        }



        public void GenerateId(List<string> speciesList)
        {
            //store the first letter of species, the first two letters of the breed and as well as the DOB and what species has been entered
            iD = speciesList[species].Substring(0, 2).ToLower() + dateOfBirth.Year + speciescounter;
            //generate an unique Id by adding thoes values together
        }




        // Determines that the status is alive for animal at start of program
        public string Animalalive()
        {
            string status = "Status: Dead\n";
            if (statusOfAnimal == true)
            {
                status = "Status: Alive\n";
            }
            return status;
        }



        //adds the foodConsumedDaily to the dailyconsumption
        public void AddFoodConsumed(float dailyconsumption)
        {
            foodConsumedDaily.Add(dailyconsumption);
        }

        //Displays weekly food comsumption as a summary 
        public string GetWeeksConsumption()
        {
            string consumptionSummary = "";
            if (foodConsumedDaily.Count >7)
            {

                int day = 1;
                for (int consumptionIndex = foodConsumedDaily.Count - 7; consumptionIndex < foodConsumedDaily.Count; consumptionIndex++)
                {
                    consumptionSummary += $"Day {day}: {foodConsumedDaily[consumptionIndex]}g\n";
                    day++;
                }
            }
            else
            {
                
                for (int consumptionIndex =0 ; consumptionIndex < foodConsumedDaily.Count; consumptionIndex++)
                {
                    consumptionSummary += $"Day {consumptionIndex + 1}: {foodConsumedDaily[consumptionIndex]}g\n";

                }
            }
            
            return consumptionSummary;
        }




        public string AnimalSummary(List<string> speciesList)
        {
            //returns a string containing all the infomation the user need to know 
            string summary = $"Name: {speciesList[species]}\nDOB: {dateOfBirth.ToString("d", (new CultureInfo("es-ES")))}\n";
            summary += GetWeeksConsumption();
            return summary;
           
           

        }


        public string ToString()
        {
            return "";
        }
    }
}
