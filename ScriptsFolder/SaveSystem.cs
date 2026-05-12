using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    public static void SaveWorkouts(List<Workout> workouts)
    {
        WorkoutList workoutList = new WorkoutList(workouts);

        string json = JsonUtility.ToJson(workoutList, true);

        File.WriteAllText(Application.persistentDataPath + "/workouts.json", json);
    }

    public static List<Workout> LoadWorkouts()
    {
        string path = Application.persistentDataPath + "/workouts.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);

            WorkoutList loadedWorkouts = JsonUtility.FromJson<WorkoutList>(json);

            return loadedWorkouts.workouts;
        }

        return new List<Workout>();
    }
}