namespace Hogwarts
{
    public class ConflictLesson : Lesson
    {
        public ConflictLesson(Lesson lesson,string conflictMsg)
        {
            Name = lesson.Name;
            StartTime = lesson.StartTime;
            EndTime = lesson.EndTime;
            StudentCount = lesson.StudentCount;
            Capacity = lesson.Capacity;
            PresentationTerm = lesson.PresentationTerm;
            Msg = conflictMsg;
        }
        string Msg { get; set; }
    }
}