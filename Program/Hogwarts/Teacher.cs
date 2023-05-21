using System;
using System.Collections.Generic;

namespace Hogwarts
{
    public class Teacher : AllowedPerson, ITimeTableConflicts
    {
        public Teacher(Human human)
        {
            // This constructor is for when we want to make instances of Teacher class with including properties of another human class instance -->

            this.Gender = human.Gender;
            this.Breed = human.Breed;
            this.Name = human.Name;
            this.LastName = human.LastName;
            this.BirthDate = human.BirthDate;
            this.Father = human.Father;
            this.Username = human.Username;
            this.Password = human.Password;
            this.Role = human.Role;
        }


        //------------------------------------------------------------------------------------------------
        //----Here when students or teachers want to choose some lessons for studying or teaching -->    |
        //----this function first will be run to check if the time table of lessons have conflicts or not|
        //------------------------------------------------------------------------------------------------

        public List<ConflictLesson> TimeTableConflicts(List<Lesson> lessons)
        {
            List<ConflictLesson> lessonConflicts = new List<ConflictLesson>();

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
                        lessonConflicts.Add(new ConflictLesson(lessons[j],
                            $"{lessons[i].Name} Section Has Conflict With {lessons[j].Name}!"));
                }
            }

            //----------------------------------------------------------------------------------------------

            return lessonConflicts;
        }

        public void GetLessonsForTeach(List<Lesson> chosenLessons)
        {
            if (TimeTableConflicts(chosenLessons).Count == 0)
            {
                CurrentTermForTeachLessons.AddRange(chosenLessons);
            }
            else
            {
                /*
    
                Here we can show conflict lessons to user
                ----Some Events that comes from UI----
   
                */

                //After all when user clicked OK-->
                //GetLessonsForTeach(new lessons that come from UI);   
            }
        }

        //------------------------------------------------------------------------------------------------
        public bool TeachMultipleLessons { get; set; }
        public List<Lesson> CurrentTermForTeachLessons { get; set; }

        //Randomly gives teacher an specific Immorality.
        
        public readonly double ImmoralityPercent = new Random().Next(5, 61);
    }
}