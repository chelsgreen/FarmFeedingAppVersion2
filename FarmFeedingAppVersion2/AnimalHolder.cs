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
        private float foodConsumed;
        private int speciescounter ;
        
        private List<float> foodConsumedDaily;
        private string iD;
        private DateTime dateTime;       
        private List<float> foodPrices = new List<float>() { 0.00165f, 0.0018f, 0.00155f };

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

            // Update the status based on the new data
            UpdateStatus();
        }

        public List<float> GetFoodConsumedDaily()
        {
            //Gets the food consumed by an animal
            return foodConsumedDaily;
        }



        public int GetSpecies()
        {
           //Gets the species the user inputed
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

        public void UpdateStatus()           
        {
            float someThreshold = 1000.0f;
            // Check a condition to determine the status, for example, based on food consumption
            if (CalculateWeeklyConsumption() < someThreshold)
            {
                statusOfAnimal = false; // Set the status to false (unhealthy or sick)
            }
            else
            {
                statusOfAnimal = true; // Set the status to true (alive or healthy)
            }
        }



        public float CalculateTotalCost(float costPerKg)
        {
          
            //Program Multiplys the cost per kg by animals weekly consumption
            return CalculateWeeklyConsumption() * costPerKg;
            Console.WriteLine();
        }



        public float CalculateWeeklyConsumption()
        {


            float sumConsumption = 0;
            //calculate the last 7 days of food consumption
            if (foodConsumedDaily.Count >6)
            {
                for (int dailyConsumptionIndex = foodConsumedDaily.Count - 1; dailyConsumptionIndex > foodConsumedDaily.Count - 8; dailyConsumptionIndex--)
                {
                    sumConsumption += foodConsumedDaily[dailyConsumptionIndex];
                }
            }
            else
            {
                for (int dailyConsumptionIndex = 0; dailyConsumptionIndex  < foodConsumedDaily.Count ; dailyConsumptionIndex++)
                {
                    sumConsumption += foodConsumedDaily[dailyConsumptionIndex];
                }
            }
            //add each daily consumption to sum consumption varilable
          

            //return total weekly consumtion

            return sumConsumption;
        }

        public float costOfFood(float price)
        {                      

        //Calculates the weeklyconsumption by the price of the animals consumption
           return CalculateWeeklyConsumption() * price;
        }



        public void GenerateId(List<string> speciesList, List<AnimalHolder> allAnimals)
        {
            // Store the first letter of species, the first two letters of the breed, and as well as the DOB
            string speciesAbbreviation = speciesList[species].Substring(0, 2).ToLower();
            string yearOfBirth = dateOfBirth.Year.ToString();

            // Get the count of animals of the same species in the list
            int speciesCount = allAnimals.Count(a => a.GetSpecies() == species);

            // Append the species count and original animal holder ID to make it unique
            iD = speciesAbbreviation + yearOfBirth +"#"+ speciesCount + iD;
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




        public string AnimalSummary(List<string> speciesList, float costPerKg)
        {
            // Calculate the total amount of food consumed
            float totalFoodConsumed = CalculateWeeklyConsumption();

            // Calculate the total cost based on the provided cost per kg
            float totalCost = totalFoodConsumed * costPerKg;

            // Create the summary string
            string summary = $"Name: {speciesList[species]}\nID: {iD}\nDOB: {dateOfBirth.ToString("d", (new CultureInfo("es-ES")))}\n";
            summary += GetWeeksConsumption();
            summary += $"\nTotal Amount of food consumed: {totalFoodConsumed}g\n";
            summary += $"Total Cost ${totalCost}\n";

            return summary;
        }


        public string ToString()
        {
            return "";
        }
    }
}
