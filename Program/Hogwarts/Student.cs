using System.Collections.Generic;

namespace Hogwarts
{
    public class Student : AllowedPerson
    {
        public List<Lesson> PassedLessons { get; set; }
        public int CurrentTerm { get; set; }
        public int DormitoryCode { get; set; }
    }
}