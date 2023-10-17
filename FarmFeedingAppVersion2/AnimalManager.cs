using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeedingAppVersion2
{
    public class AnimalManager
    {
        private List<AnimalHolder> animalHolders = new List<AnimalHolder>();
        private List<string> animal = new List<string>() { "Chicken", "Pig", "Sheep" };
        //food price per gram
        private List<float> foodPrices = new List<float>() { 0.00165f, 0.0018f, 0.00155f };
        int speciescount = 0;
        
        public AnimalManager()
        {

        }

        public string GetAnimal(int animalIndex)
        {

            return animal[animalIndex];
        }
        public List<AnimalHolder> GetAnimals()
        {
            return animalHolders;
        }



        //Creates New Animal Holder
        public void AddAnimalHolder(AnimalHolder newAnimalHolder)
        {
            animalHolders.Add(newAnimalHolder);

            // Pass the speciesList and allAnimals list to the GenerateId method
            newAnimalHolder.GenerateId(animal, animalHolders);
        }

        //Adds the animals consumption to the animal
        public void AddAnimalConsumption(int dailyConsumption, string selectedAnimal)
        {
            if (selectedAnimal.Equals(""))
            {
                animalHolders[animalHolders.Count - 1].AddAnimalConsumption(dailyConsumption);
            }
            else
            {
                animalHolders[FindAnimal(selectedAnimal)].AddAnimalConsumption(dailyConsumption);
            }

        }
        //Calculates the total amount of food Consumed by the animal
        public List<float> TotalAmountOfFood()
        {

            List<float> totalConsumption = new List<float>() { 0, 0, 0 };



            foreach (AnimalHolder animal in animalHolders)
            {
                //adds the total consumption to the weekly consumption
                totalConsumption[animal.GetSpecies()] += animal.CalculateWeeklyConsumption();
            }

            return totalConsumption;
        }

        internal List<AnimalHolder> AddAnimalHolder(AnimalHolder animalHolder, object newAnimalHolder)
        {
            throw new NotImplementedException();
        }

        public string AnimalsConsumptionSummary()
        {
            string summary = "";
            int indexcounter = 0;

            foreach (float speciesConsumption in TotalAmountOfFood())
            {
                //adds to list a the increase by one
                summary += $"{animal[indexcounter]}, {speciesConsumption}\n";
                indexcounter++;
            }
            //returns a summary of the total amount of the food consumed 
            return summary;
        }


        //determines is animals is healthly based on food consumption
        public bool CheckAnimalsHealth()
        {
            //compare average consumption with its daily consumption

            // if animal consumption is less than its average consumption return true else retrun false
            return true;
        }
        // returns a string containing id, food consumption within the last 30 day and the cost of the food
        public string HighestCostAnimal()
        {

            return "";
        }

        //Calculates the species feed cost per grams
        public List<float> CalculateSpeciesFeedCost()
        {
            List<float> speciesCost = new List<float>() { 0, 0, 0 };

            for (int i = 0; i < speciesCost.Count; i++)
            {
                speciesCost[i] += TotalAmountOfFood()[i] * foodPrices[i];
            }
            return speciesCost;
        }

        //Finds the Animal based off its ID
        public int FindAnimal(string iD)
        {
            foreach (var animalHolder in animalHolders)
            {
                if (animalHolder.GetID().Equals(iD))
                {
                    return animalHolders.IndexOf(animalHolder);
                }
            }
            return -1;
        }

        //Displays weekly food consumption as a Summary 
        public string ConsumptionSummary(string selectAnimal)
        {
            if (selectAnimal.Equals(""))
            {
                return animalHolders[animalHolders.Count - 1].AnimalSummary(animal, foodPrices[animalHolders[animalHolders.Count - 1].GetSpecies()]);
            }
            else
            {
                int animalIndex = FindAnimal(selectAnimal);
                if (animalIndex >= 0)
                {
                    return animalHolders[animalIndex].AnimalSummary(animal, foodPrices[animalHolders[animalIndex].GetSpecies()]);
                }
                else
                {
                    return "Species not found.";
                }
            }
        }
        public string MainSummary(string species)
        {
            
            string summary = "Feeding Summary\nTotal Costs of:\n";
            float totalconsumed = 0;
            string summaryconsumption = "Total Amount of food consumed:\n";

            if (species.Equals("All"))
            {
                List<float> totalFoodConsumed = TotalAmountOfFood();

                for (int i = 0; i < animal.Count; i++)
                {
                    float cost = totalFoodConsumed[i] * foodPrices[i];

                   
                    summary += $"{animal[i]}: ${cost:F2}\n"; // Display the cost in dollars with two decimal places

                    // Calculate and append the total food consumed to summaryconsumption
                    totalconsumed += totalFoodConsumed[i];
                }
            }
            else
            {
                int speciesIndex = animal.IndexOf(species);
                if (speciesIndex >= 0)
                {
                    float cost = TotalAmountOfFood()[speciesIndex] * foodPrices[speciesIndex];

                    // Append species name and cost inside the 'else' block
                    summary += $"{species}: ${cost:F2}\n"; // Display cost in dollars with two decimal places

                    // Calculates and adds the total food consumed to summaryconsumption
                    totalconsumed = TotalAmountOfFood()[speciesIndex];
                }
                else
                {
                    summary += "Species not found.\n";
                }
            }

            summaryconsumption += totalconsumed;

            // Combine both summaries into a single string and return it
            return summary + "\n" + summaryconsumption+"g";
        }


    }
}