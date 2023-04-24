using System;
using System.Collections.Generic;

namespace Hogwarts
{
    public class Herbology : Lesson
    {
        public static List<Plant> Term1Plants { get; set; }
        public static List<Plant> Term2Plants { get; set; }
        public static List<Plant> Term3Plants { get; set; }

        public static List<Plant> Term4Plants { get; set; }

        //AddTermXPlants method --> For changing Term1Plants lists in the class itself
        private static void AddTermXPlants(int term, Plant chosedPlant)
        {
            switch (term)
            {
                case 1:
                {
                    Term1Plants.Add(chosedPlant);
                    break;
                }
                case 2:
                {
                    Term2Plants.Add(chosedPlant);
                    break;
                }
                case 3:
                {
                    Term3Plants.Add(chosedPlant);
                    break;
                }
                case 4:
                {
                    Term4Plants.Add(chosedPlant);
                    break;
                }
                default:
                {
                    Term4Plants.Add(chosedPlant);
                    break;
                }
            }
        }

        //----------------------------------------------------------------
        public static void GeneratePlantsOfTerms()
        {
            //Generates all plants with randomized counts

            Random rCount = new Random();
            List<Plant> rPlants = new List<Plant>();

            foreach (PlantName plantName in Enum.GetValues(typeof(PlantName)))
            {
                rPlants.Add(new Plant(plantName, rCount.Next(1, 101)));
            }
            //------------------------------------------------------------------

            //Here this method Generates randomized plants randomly for all terms

            Random rindex = new Random();
            int generationPlace = 1;

            while (rPlants.Count != 0)
            {
                int randIndex = rindex.Next(0, rPlants.Count);
                AddTermXPlants(generationPlace, rPlants[randIndex]);
                rPlants.Remove(rPlants[randIndex]);

                if (generationPlace != 4)
                    generationPlace++;
                else
                    generationPlace = 1;
            }
        }
    }
}