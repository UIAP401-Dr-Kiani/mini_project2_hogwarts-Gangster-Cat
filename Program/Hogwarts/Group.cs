using System.Collections.Generic;

namespace Hogwarts
{
    public class Group
    {
        //----------------------------------------------------------------
        //Note: This Properties are not implemented yet!-->
        //----------------------------------------------------------------
        //public Type Type { get; set; }
        //----------------------------------------------------------------  
        public int Point { get; set; }
        public List<AllowedPerson> Persons { get; set; }
        public List<AllowedPerson> QuidditchParticipants { get; set; }
    }
}