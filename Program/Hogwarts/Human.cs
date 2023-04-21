using System;

namespace Hogwarts
{
    public class Human
    {
        public Human(string name, string lastName, string birthDate, string gender, string father, string breed,
            string username, string password)
        {
            //|--------------------------------------------------------------------------|
            //|-----Constructor of Human class which determines Gender and Breed too-----|
            //|------------If Gender or Breed is not valid then it'll be null------------|
            //|--------------------------------------------------------------------------|

            //---------------------------------------------------------------->>>>

            if (Enum.TryParse(gender, true, out HumanGender _gender))
                Gender = (HumanGender)Enum.Parse(typeof(HumanGender), gender, true);
            else
                Gender = null;
            //-----------------------------------------------------------------

            if (Enum.TryParse(breed, true, out HumanBreed _breed))
                Breed = (HumanBreed)Enum.Parse(typeof(HumanBreed), breed, true);
            else
                Breed = null;
            //---------------------------------------------------------------- 

            Name = name;
            LastName = lastName;
            BirthDate = birthDate;
            Father = father;
            Username = username;
            Password = password;
        }

        //----------------------------------------------------------------
        protected Human()
        {
            //For base class usage only
        }

        //----------------------------------------------------------------
        public string Name { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public HumanGender? Gender { get; set; }
        public HumanBreed? Breed { get; set; }
        public string Father { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}