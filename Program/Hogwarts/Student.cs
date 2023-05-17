using System;
using System.Collections.Generic;

namespace Hogwarts
{
    public class Student : AllowedPerson, ITimeTableConflicts
    {
        public Student(Human human)
        {
            // This constructor is for when we want to make instances of Student class with including properties of another human class instance -->

            foreach (var property in typeof(Human).GetFields())
            {
                property.SetValue(this, property.GetValue(human));
            }
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
                if (lessons[i].Capacity == lessons[i].StudentCount)
                    lessonConflicts.Add(new ConflictLesson(lessons[i], $"{lessons[i].Name} Is Full!"));


                for (int j = 0; j < lessons.Count; j++)
                {
                    if (lessons[i].StartTime == lessons[j].StartTime && i != j)
                        lessonConflicts.Add(new ConflictLesson(lessons[j],
                            $"{lessons[i].Name} Section Has Conflict With {lessons[j].Name}!"));
                }
            }


            return lessonConflicts;
        }

        public List<ConflictLesson> PassedLessonsConflicts(List<Lesson> chosenLessons)
        {
            List<ConflictLesson> conflictPassedLessons = new List<ConflictLesson>();
            foreach (var chosenLesson in chosenLessons)
            {
                foreach (var passedLesson in PassedLessons)
                {
                    if (chosenLesson.Name == passedLesson)
                    {
                        conflictPassedLessons.Add(new ConflictLesson(chosenLesson,
                            "This Lesson have already passed!"));
                        break;
                    }
                }
            }

            return conflictPassedLessons;
        }
        //----------------------------------------------------------------------------------------------

        //Generate random group if current term is one and if it's not, it'll just do nothing!
        public void GenerateGroup(List<Group> groups)
        {
            if (CurrentTerm == 1)
            {
                int randGroupIndex = new Random().Next(0, groups.Count);
                Group = groups[randGroupIndex];
                groups[randGroupIndex].Students.Add(this);
            }
        }

        //Generate random lessons if current term is one and if it's not, it'll call the choose lessons function.
        public void GetLessons(List<Lesson> lessons)
        {
            if (CurrentTerm == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    Random randGenerator = new Random();
                    int randLessonIndex;
                    bool isRepetitious;
                    do
                    {
                        isRepetitious = false;
                        randLessonIndex = randGenerator.Next(0, lessons.Count);
                        foreach (var lesson in CurrentTermLessons)
                        {
                            if (lesson == lessons[randLessonIndex])
                                isRepetitious = true;
                        }
                    } while (isRepetitious);

                    CurrentTermLessons.Add(lessons[randLessonIndex]);
                }
            }
            else
                ChooseLessons(lessons);
        }

        private void ChooseLessons(List<Lesson> chosenLessons)
        {
            if (TimeTableConflicts(chosenLessons).Count == 0 && PassedLessonsConflicts(chosenLessons).Count == 0)
                CurrentTermLessons.AddRange(chosenLessons);
            else
            {
                /*
                 
                Here we can show conflict lessons to user
                ----Some Events that comes from UI----
                
                */

                //After all when user clicked OK-->
                //ChooseLessons(new lessons that come from UI);
            }
        }

        //Process that if the student can pass this lesson or not.(by Immorality of it's teacher and he/she's score) -->
        public bool CanPassLesson(Lesson lesson, double examScore)
        {
            return ((examScore - (new Random().Next(0, 2) * (lesson.Teacher.ImmoralityPercent * examScore)) >= 50));
        }

        //------------------------------------------------------------------------------------------------
        public List<LessonName> PassedLessons { get; set; }

        public List<Lesson> CurrentTermLessons { get; set; }
        public int CurrentTerm { get; set; }
        public string DormitoryCode { get; set; }
        public TrainTicket TrainTicket { get; set; }

        public bool HasEnteredHogwarts { get; set; }
    }
}