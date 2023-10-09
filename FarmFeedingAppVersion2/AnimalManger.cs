using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeedingAppVersion2
{
    public class AnimalManger
    {
        private List<AnimalHolder> animalHolders = new List<AnimalHolder>();
        private List<string> animal = new List<string>() { "Chicken", "Sheep", "Pig" };
        //food price per gram
        private List<float> foodPrices = new List<float>() { 0.00165f, 54.5f, 43 };
        int speciescount = 0;
      
        public AnimalManger()
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
            animalHolders[animalHolders.Count - 1].GenerateId(animal);
            
        }
        public void AddAnimalConsumption(int dailyConsumption,string selectedAnimal)
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
                return animalHolders[animalHolders.Count-1].AnimalSummary(animal);
            }
            else
            {
                return animalHolders[FindAnimal(selectAnimal)].AnimalSummary(animal);
            }
            
            
        }
        public string MainSummary(string species)
        {
            string summarys ="Feeding Summary\n" +
                $"Species: {species}\n" +
                $"Total cost of food:\n"+ 
                $"Total food consumed:";
            float totalconsumed = 0;
            float itemCost = 0f;

            string currentspecie = species;
            float currentCost = foodPrices[0];

           

            if(species .Equals("All") )
            {
                foreach (var foodconsumed in TotalAmountOfFood())
                {
                   totalconsumed += foodconsumed;
                    
                }
            }
           else
            {
                List<float> test = TotalAmountOfFood();
                int test2 = animal.IndexOf(species);
                totalconsumed = TotalAmountOfFood()[this.animal.IndexOf(species)];;
           }
            
            
            summarys += totalconsumed;
            return summarys;

        }
       
    }
}
