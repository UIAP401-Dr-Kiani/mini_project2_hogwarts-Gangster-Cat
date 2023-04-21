using System.Windows.Forms.VisualStyles;

namespace Hogwarts
{
    public class Lesson
    {
        public Lesson(LessonName name, int[] startTime,int[] endTime,int studentCount,int capacity, int presentationTerm)
        {
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            StudentCount = studentCount;
            Capacity = capacity;
            PresentationTerm = presentationTerm;
        }

        protected Lesson()
        {
            //For base class usage only
        }
        public LessonName Name { get; set; }
        public int[] StartTime = new int[2];
        public int[] EndTime = new int[2];
        public int StudentCount { get; set; }
        public int Capacity { get; set; }
        public int PresentationTerm { get; set; }
    }
}