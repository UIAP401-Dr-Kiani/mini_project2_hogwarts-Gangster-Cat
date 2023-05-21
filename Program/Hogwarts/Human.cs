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
        [JsonProperty("gender")] public string StringGender { get; set; }
        private HumanGender? _HumanGender { get; set; }
        public HumanGender? Gender
        {
            get
            {
                if (_HumanGender != null)
                    return _HumanGender;
                else if (StringGender != null || StringGender != "")
                {
                    if (Enum.TryParse(StringGender.Replace(" ", ""), true, out HumanGender _gender))
                        _HumanGender = (HumanGender)Enum.Parse(typeof(HumanGender), StringGender.Replace(" ", ""), true);
                    else
                        return null;

                    return _HumanGender;
                }
                else
                    return null;
            }
            set
            {
                _HumanGender = value;
            }
        }

        [JsonProperty("type")] public string StringBreed { get; set; }
        private HumanBreed? _HumanBreed { get; set; }

        public HumanBreed? Breed
        {
            get
            {
                if (_HumanBreed != null)
                    return _HumanBreed;
                else if (StringBreed != null || StringBreed != "")
                {
                    if (Enum.TryParse(StringBreed.Replace(" ", ""), true, out HumanBreed _breed))
                        _HumanBreed = (HumanBreed)Enum.Parse(typeof(HumanBreed), StringBreed.Replace(" ", ""), true);
                    else
                        return null;

                    return _HumanBreed;
                }
                else
                    return null;
            }
            set
            {
                _HumanBreed = value;
            }
        }

        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("family")] public string LastName { get; set; }
        [JsonProperty("dateOfBirth")] public string BirthDate { get; set; }


        [JsonProperty("father")] public string Father { get; set; }
        [JsonProperty("username")] public string Username { get; set; }
        [JsonProperty("password")] public string Password { get; set; }
        [JsonProperty("role")] public PersonRole Role { get; set; }
    }
}