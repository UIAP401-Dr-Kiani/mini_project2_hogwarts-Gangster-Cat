namespace Hogwarts
{
    public class Human
    {
        public Human(string name,string lastName,string birthDate,string gender,string father,string breed,string username,string password)
        {
            Name = name;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = (HumanGender)int.Parse(gender);
            Breed = (HumanBreed)int.Parse(breed);
            Username = username;
            Father = father;
            Password = password;
        }
             public string Name { get; set; }
             public string LastName { get; set; }
             public string BirthDate { get; set; }
             public HumanGender Gender { get; set; }
             public string Father { get; set; }
             public string Username { get; set; }
             public string Password { get; set; }
             public HumanBreed Breed  { get; set; }
    }
}