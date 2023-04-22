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
        public AcceptedPersonRole Role { get; set; }
        public string[] Mails { get; set; }
    }
}