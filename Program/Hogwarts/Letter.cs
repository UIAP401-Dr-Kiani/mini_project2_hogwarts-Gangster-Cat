namespace Hogwarts
{
    public class Letter
    {
        public Letter(string[] text, LetterSubject subject )
        {
            Text = text;
            Subject = subject;
        }
        public string[] Text { get; set; }
        public LetterSubject Subject { get; set; }
    }
}