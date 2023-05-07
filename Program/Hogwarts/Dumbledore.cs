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

        public bool IsAccepted(Human person)
        {
            //Right now all Humans are accepted!
            return true;
        }

        public void ValidateHumans(List<Student> validStudents, List<Teacher> validTeachers)
        {
            List<Human> humans;
            using (StreamReader reader = new StreamReader("../../../../Files/JSON_DATA.json"))
            {
                string humansFileString = reader.ReadToEnd();
                humans = JsonConvert.DeserializeObject<List<Human>>(humansFileString);
            }

            foreach (var person in humans)
            {
                if (person.Role == AcceptedPersonRole.Student)
                    validStudents.Add(new Student(person));
                else if (person.Role == AcceptedPersonRole.Teacher)
                    validTeachers.Add(new Teacher(person));
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