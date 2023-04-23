namespace Hogwarts
{
    public class Dormitory
    {
        Dormitory(HumanGender dormitoryGender, Group dormitoryGroup)
        {
            _filledPlace[0] = 1;
            _filledPlace[1] = 1;
            _filledPlace[2] = 0;
            FloorCount = 6;
            RoomCount = 10;
            BedCount = 5;
            Gender = dormitoryGender;
            Group = dormitoryGroup;
        }

        Dormitory(HumanGender dormitoryGender, Group dormitoryGroup, int floorCount, int roomCount, int bedCount)
        {
            _filledPlace[0] = 1;
            _filledPlace[1] = 1;
            _filledPlace[2] = 0;
            FloorCount = floorCount;
            RoomCount = roomCount;
            BedCount = bedCount;
            Gender = dormitoryGender;
            Group = dormitoryGroup;
        }

        public Group Group { get; set; }
        public static int FloorCount { get; set; }
        public static int RoomCount { get; set; }
        public static int BedCount { get; set; }

        //[0]Floor [1]Room [2]Bed
        private readonly int[] _filledPlace = new int[3];
        public bool IsFull { get; set; }

        public int[] Code => _filledPlace;

        //------------------------------------------------------------------------------------------------------------------------|
        //----AddStudent method : Generates Code property of Dormitory class and also generates last filled place of dormitory----|
        //---------------------At the end --> If all dormitory places are filled ISFull property will be true---------------------|
        //------------If dormitory isn't full student.DormitoryCode will be set to Dormitory.Code otherwise it'll be: ------------|
        //---------------------------------------"-No Dormitory Was Found For This Student"---------------------------------------|
        //------------------------------------------------------------------------------------------------------------------------|
        public void AddStudent(Student student)
        {
            if (_filledPlace[2] != 5)
            {
                _filledPlace[2]++;
            }
            else if (_filledPlace[1] != 10)
            {
                _filledPlace[1]++;
                _filledPlace[2] = 1;
            }
            else if (_filledPlace[0] != 6)
            {
                _filledPlace[0]++;
                _filledPlace[1] = 1;
                _filledPlace[2] = 1;
            }
            else
                IsFull = true;

            if (IsFull == false)
                student.DormitoryCode = $"{Code[0]}{Code[1]}{Code[2]}";
            else
                student.DormitoryCode = "-No Dormitory Was Found For This Student";
        }

        public static HumanGender Gender { get; set; }
    }
}