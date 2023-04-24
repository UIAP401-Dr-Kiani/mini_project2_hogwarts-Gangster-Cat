using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Hogwarts
{
    public class Magic : Lesson
    {
        public static List<Spell> Spells
        {
            get
            {
                using (StreamReader reader = new StreamReader("../../../../Files/spells.json"))
                {
                    string jsonSpells = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<Spell>>(jsonSpells);
                }
            }
        }
    }
}