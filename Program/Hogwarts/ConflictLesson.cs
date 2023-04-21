namespace Hogwarts
{
    public class ConflictLesson : Lesson
    {
        public ConflictLesson(LessonName name, int[] startTime,int[] endTime,int studentCount,int capacity, int presentationTerm,string msg)
        {
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            StudentCount = studentCount;
            Capacity = capacity;
            PresentationTerm = presentationTerm;
            Msg = msg;
        }
        string Msg { get; set; }
    }
}