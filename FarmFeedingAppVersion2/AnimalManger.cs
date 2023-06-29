﻿using System;
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
        private List<float> foodPrices = new List<float>() { 2f, 54.5f, 43 };
     
        public AnimalManger()
        {



        }
        public void AddAnimalHolder(AnimalHolder newAnimalHolder)
        {
            animalHolders.Add(newAnimalHolder);
        }
        public void AddAnimalConsumption(int dailyConsumption)
        {

            animalHolders[animalHolders.Count -1].AddAnimalConsumption(dailyConsumption);
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
        public List<float> CalculateSpeciesFeedCost()
        {
            List<float> speciesCost = new List<float>() { 0, 0, 0 };

            for (int i = 0; i < speciesCost.Count; i++)
            {
                speciesCost[i] += TotalAmountOfFood()[i] * foodPrices[i];
            }
            return speciesCost;
        }
        public string ConsumptionSummary()
        {
            return animalHolders[animalHolders.Count - 1].AnimalSummary(animal);
            
        }
    }
}
