using System;
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
        private bool IsAcceptedToHogwarts(Human person)
        {
            return person.Breed == HumanBreed.HalfBlood || person.Breed == HumanBreed.PureBlood;
        }

        private bool IsRegularPerson(Human person) => !IsAcceptedToHogwarts(person);

        public void ValidateHumans(List<Student> validStudents, List<Teacher> validTeachers, List<Human> regularHumans)
        {
            List<Human> validPersons;
            using (StreamReader reader = new StreamReader("../../../../Files/JSON_DATA.json"))
            {
                string humansFileString = reader.ReadToEnd();
                List<Human> humans = JsonConvert.DeserializeObject<List<Human>>(humansFileString);
                validPersons = humans.FindAll(IsAcceptedToHogwarts);
                regularHumans.AddRange(humans.FindAll(IsRegularPerson));
            }

            foreach (var person in validPersons)
            {
                switch (person.Role)
                {
                    case PersonRole.Student:
                        validStudents.Add(new Student(person));
                        break;
                    case PersonRole.Teacher:
                        validTeachers.Add(new Teacher(person));
                        break;
                    default: break;
                }
            }
        }


        //Welcome Message: --> 

        /*Dear {student.Name}  ,
           We are pleased to inform you that you have been accepted at Hogwarts School of Witchcraft and Wizardry. Please find enclosed a list of all necessary books and equipment.
           Term begins on 1 September. We await your owl by no later than 31 July.
           Yours sincerely,
           
           Your Ticket Code is: {student.TicketCode}
           
           */

        // TrainTicket Generator -->

        public void GenerateStudentTicket(Student student, List<TrainTicket> ticketList)
        {
            Random rnd = new Random();
            bool isRepetitious = false;
            int[] rndTicketCode = new int[5];
            do
            {
                // Day:
                rndTicketCode[0] = rnd.Next(1, 8);
                // StartTime(Hour):
                rndTicketCode[1] = rnd.Next(0, 25);
                // StartTime(Minute):
                rndTicketCode[2] = rnd.Next(0, 61);
                // CabinCode:
                rndTicketCode[3] = rnd.Next(1, 11);
                // SeatCode:
                rndTicketCode[4] = rnd.Next(1, 9);

                foreach (var checkingTicket in ticketList)
                {
                    if (rndTicketCode == checkingTicket.TicketCode)
                        isRepetitious = true;
                }
            } while (isRepetitious);

            student.TrainTicket = new TrainTicket(rndTicketCode);
        }
    }
}