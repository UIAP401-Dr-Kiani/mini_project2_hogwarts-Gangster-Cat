using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Hogwarts
{
    public class Dumbledore : AllowedPerson
    {
        public List<Dormitory> Dormitories = new List<Dormitory>();

        //------------------------------------------------------------------------------------------------
        // Admin panel functions -->

        private static bool IsAcceptedToHogwarts(Human person)
        {
            return person.Breed == HumanBreed.HalfBlood || person.Breed == HumanBreed.PureBlood;
        }

        private static bool IsRegularPerson(Human person) => !IsAcceptedToHogwarts(person);

        public void ValidateHumans(List<Student> validStudents, List<Teacher> validTeachers, List<Human> regularHumans)
        {
            List<Human> validPersons;
            using (StreamReader reader = new StreamReader("../../../../Files/JSON_DATA.json"))
            {
                List<Human> humans;
                string humansFileString = reader.ReadToEnd();
                humans = JsonConvert.DeserializeObject<List<Human>>(humansFileString);
                validPersons = humans.FindAll(IsAcceptedToHogwarts);
                regularHumans.AddRange(humans.FindAll(IsRegularPerson));
            }

            foreach (var person in validPersons)
            {
                switch (person.Role)
                {
                    case AcceptedPersonRole.Student:
                        validStudents.Add(new Student(person));
                        break;
                    case AcceptedPersonRole.Teacher:
                        validTeachers.Add(new Teacher(person));
                        break;
                    default: break;
                }
            }
        }


        //Welcome Message: --> 

        /*Dear Mr Potter,
           We are pleased to inform you that you have been accepted at Hogwarts School of Witchcraft and Wizardry. Please find enclosed a list of all necessary books and equipment.
           Term begins on 1 September. We await your owl by no later than 31 July.
           Yours sincerely,*/


        public void SendMessageToStudents(string message, List<Student> students)
        {
            foreach (var student in students)
                student.Mails.Add(message);
        }
    }
}