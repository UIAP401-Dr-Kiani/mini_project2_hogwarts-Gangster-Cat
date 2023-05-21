using System.Collections.Generic;
using System.Threading;

namespace Hogwarts
{
    public static class MainMethods
    {
        public static bool IsUserInfoCorrect(List<Student> students, string userName, string password)
        {
            foreach (var student in students)
            {
                if (student.Username == userName && student.Password == password)
                    return true;
            }

            return false;
        }
        public static bool IsUserInfoCorrect(List<Teacher> teachers, string userName, string password)
        {
            foreach (var teacher in teachers)
            {
                if (teacher.Username == userName && teacher.Password == password)
                    return true;
            }

            return false;
        }
        
        public static bool IsUserInfoCorrect(Dumbledore dumbledore, string password)
        {
            if (dumbledore.Password == password)
                return true;
            else
                return false;
        }

    }
}