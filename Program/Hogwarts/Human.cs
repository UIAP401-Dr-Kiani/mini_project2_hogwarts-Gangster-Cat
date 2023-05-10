using System;
using Newtonsoft.Json;

namespace Hogwarts
{
    public class Human
    {
        protected Human()
        {
            //For base class usage only
        }


        //|--------------------------------------------------------------------------|
        //|------------ Human class which determines Gender and Breed too------------|
        //|------------If Gender or Breed is not valid then it'll be null------------|
        //|--------------------------------------------------------------------------|

        //---------------------------------------------------------------->>>>
        [JsonProperty("gender")] public string StringGender { get; }

        public HumanGender? Gender
        {
            get
            {
                if (Enum.TryParse(StringGender.Replace(" ", ""), true, out HumanGender _gender))
                    return (HumanGender)Enum.Parse(typeof(HumanGender), StringGender.Replace(" ", ""), true);
                else
                    return null;
            }
        }

        [JsonProperty("type")] public string StringBreed { get; }

        public HumanBreed? Breed
        {
            get
            {
                if (Enum.TryParse(StringBreed.Replace(" ", ""), true, out HumanBreed _breed))
                    return (HumanBreed)Enum.Parse(typeof(HumanBreed), StringBreed.Replace(" ", ""), true);
                else
                    return null;
            }
        }

        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("family")] public string LastName { get; set; }
        [JsonProperty("dateOfBirth")] public string BirthDate { get; set; }


        [JsonProperty("father")] public string Father { get; }
        [JsonProperty("username")] public string Username { get; set; }
        [JsonProperty("password")] public string Password { get; set; }
        [JsonProperty("role")] public PersonRole Role { get;}
    }
}