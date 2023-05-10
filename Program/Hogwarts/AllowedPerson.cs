using System.Collections.Generic;

namespace Hogwarts
{
    public class AllowedPerson : Human
    {
        protected AllowedPerson()
        {
            //For base class usage only
        }
        //----------------------------------------------------------------

        public Group Group { get; set; }
        public Pet Pet { get; set; }
        public bool HasSuitCase { get; set; }
        public List<Letter> Mails { get; set; }

        public void SendLetter(Letter letter, List<Student> students)
        {
            foreach (var student in students)
                student.Mails.Add(letter);
        }

        public void SendLetter(Letter letter, List<Teacher> teachers)
        {
            foreach (var teacher in teachers)
                teacher.Mails.Add(letter);
        }

        public void SendLetter(Letter letter, Dumbledore dumbledore)
        {
            dumbledore.Mails.Add(letter);
        }
    }
}