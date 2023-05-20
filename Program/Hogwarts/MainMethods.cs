using System.Collections.Generic;

namespace Hogwarts
{
    public static class MainMethods
    {
        public static bool IsUserInfoCorrect(List<object> fromChosenHumans, string password, string userName)
        {
            //--Returns false if username or password is incorrect
            //--Also returns false when the object list is not valid

            if (fromChosenHumans.GetType() == typeof(List<Student>))
            {
                List<Student> stds = new List<Student>();
                foreach (var humanObject in fromChosenHumans)
                    stds.Add((Student)humanObject);

                foreach (var std in stds)
                {
                    if (std.Username == userName && std.Password == password)
                        return true;
                }
            }
            else if (fromChosenHumans.GetType() == typeof(List<Teacher>))
            {
                List<Teacher> teachers = new List<Teacher>();
                foreach (var humanObject in fromChosenHumans)
                    teachers.Add((Teacher)humanObject);

                foreach (var tchr in teachers)
                {
                    if (tchr.Username == userName || tchr.Password == password)
                        return true;
                }
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