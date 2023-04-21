namespace Hogwarts
{
    public class AllowedPerson : Human
    {
        AllowedPerson()
        {
        }

        //Note: This Properties are not implemented yet!
        //----------------------------------------------------------------
        //Curriculum:-->Persian: BranamehDarsi
        
        //public string Curriculum { get; set; }
        //----------------------------------------------------------------
        public Group Group { get; set; }
        public int RoomCode { get; set; }
        public Pet Pet { get; set; }
        public bool HasCase { get; set; }
        public AcceptedPersonRole Role { get; set; }
        public string[] Mails { get; set; }
    }
}