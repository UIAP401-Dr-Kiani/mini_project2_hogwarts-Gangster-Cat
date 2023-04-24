using System;
using System.Collections.Generic;

namespace Hogwarts
{
    public class Sport : Lesson
    {
        public static List<SportType> Types
        {
            get
            {
                List<SportType> typeList = new List<SportType>();
                foreach (SportType sport in Enum.GetValues(typeof(SportType)))
                {
                    typeList.Add(sport);
                }
                return typeList;
            }
        }
    }
}