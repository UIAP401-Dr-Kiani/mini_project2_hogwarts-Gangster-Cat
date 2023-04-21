using System.Collections.Generic;

namespace Hogwarts
{
    public interface ITimeTableConflicts
    {
        List<ConflictLesson> TimeTableConflicts(List<Lesson> lessons);
    }
}