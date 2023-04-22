namespace Hogwarts
{
    public class Dormitory
    {
        Dormitory(HumanGender dormitoryGender,Group dormitoryGroup)
        {
            FloorCount = 6;
            RoomCount = 10;
            BedCount = 5;
            Gender = dormitoryGender;
            Group = dormitoryGroup;
        }
        Dormitory(HumanGender dormitoryGender,Group dormitoryGroup,int floorCount,int roomCount ,int bedCount)
        {
            FloorCount = floorCount;
            RoomCount = roomCount;
            BedCount = bedCount;
            Gender = dormitoryGender;
            Group = dormitoryGroup;
        } 
        
        public Group Group { get; set; }
        public int FloorCount { get; set; }
        public int RoomCount { get; set; }
        public int BedCount { get; set; }
        public static int Code { get; set; }
        
        public static HumanGender Gender { get; set; }
        
    }
}