using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Hogwarts
{
    public class Chemistry : Lesson
    {
        //Potions will be read from Files/potions.json file and then can't be overwritten through the protected property with no setter.
        public static List<Potion> Potions
        {
            get
            {
                using (StreamReader reader = new StreamReader("../Files/potions.json"))
                {
                    string jsonPotions = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<Potion>>(jsonPotions);
                }
            }
        }
    }
}