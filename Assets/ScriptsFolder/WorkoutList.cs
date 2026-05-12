using System;
using System.Collections.Generic;

[Serializable]
public class WorkoutList
{
    public List<Workout> workouts;

    public WorkoutList(List<Workout> workouts)
    {
        this.workouts = workouts;
    }
}