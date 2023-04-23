using System.Collections.Generic;

namespace Hogwarts
{
    public class Student : AllowedPerson, ITimeTableConflicts
    {
        //------------------------------------------------------------------------------------------------
        //----Here when students or teachers want to choose some lessons for studying or teaching -->    |
        //----this function first will be run to check if the time table of lessons have conflicts or not|
        //------------------------------------------------------------------------------------------------
        public List<ConflictLesson> TimeTableConflicts(List<Lesson> lessons)
        {
            List<ConflictLesson> LessonConflicts = new List<ConflictLesson>();

            //---------------------------------------------------------------------------------------------
            //----Here program will Check the reason of the conflicts foreach lesson(if has any conflicts),|
            //----and it'll explain the reason in an string------------------------------------------------|
            //----Also these lessons will be added to a list, then they'll be returned to the method-------|  
            //----------------------------------------------------------------------------------------------

            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i].Capacity == lessons[i].StudentCount)
                {
                    LessonConflicts.Add(new ConflictLesson(lessons[i].Name, lessons[i].StartTime, lessons[i].EndTime,
                        lessons[i].StudentCount, lessons[i].Capacity, lessons[i].PresentationTerm,
                        $"{lessons[i].Name} Is Full!"));
                }


                for (int j = 0; j < lessons.Count; j++)
                {
                    if (lessons[i].StartTime == lessons[j].StartTime && i != j)
                    {
                        LessonConflicts.Add(new ConflictLesson(lessons[j].Name, lessons[j].StartTime,
                            lessons[j].EndTime, lessons[j].StudentCount, lessons[j].Capacity,
                            lessons[i].PresentationTerm,
                            $"{lessons[i].Name} Section Has Conflict With {lessons[j].Name}!"));
                    }
                }
            }

            //----------------------------------------------------------------------------------------------

            return LessonConflicts;
        }

        //------------------------------------------------------------------------------------------------
        public List<LessonName> PassedLessons { get; set; }
        public List<Lesson> CurrentTermLessons { get; set; }
        public int CurrentTerm { get; set; }
        
        //After Student added to a dormitory and AddStudent method in dormitory class called DormitoryCode will be set -->
        public string DormitoryCode { get; set; }
    }
}