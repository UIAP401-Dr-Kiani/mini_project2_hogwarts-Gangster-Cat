using System.Collections.Generic;

namespace Hogwarts
{
    public class Teacher : AllowedPerson, ITimeTableConflicts
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
        public bool TeachMultipleLessons { get; set; }
    }
}