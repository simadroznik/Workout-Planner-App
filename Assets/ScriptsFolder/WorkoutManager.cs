using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class WorkoutManager : MonoBehaviour
{
    public TMP_InputField workoutInput;
    public TMP_InputField notesInput;

    public TMP_Dropdown dayDropdown;

    public List<Workout> workouts = new List<Workout>();

    private Workout editingWorkout;

    void Start()
    {
        workouts = SaveSystem.LoadWorkouts();

        if (WorkoutCardUI.workoutToEdit != null)
        {
            editingWorkout = WorkoutCardUI.workoutToEdit;

            workoutInput.text = editingWorkout.workoutName;

            notesInput.text = editingWorkout.exercise;

            dayDropdown.value =
                dayDropdown.options.FindIndex(
                    option => option.text == editingWorkout.dayOfWeek
                );
        }
    }

    public void SaveWorkout()
    {
        if (editingWorkout != null)
        {
            editingWorkout.workoutName = workoutInput.text;

            editingWorkout.exercise = notesInput.text;

            editingWorkout.dayOfWeek =
                dayDropdown.options[dayDropdown.value].text;
        }
        else
        {
            Workout newWorkout = new Workout();

            newWorkout.workoutName = workoutInput.text;

            newWorkout.exercise = notesInput.text;

            newWorkout.dayOfWeek =
                dayDropdown.options[dayDropdown.value].text;

            workouts.Add(newWorkout);
        }

        SaveSystem.SaveWorkouts(workouts);

        WorkoutCardUI.workoutToEdit = null;

        SceneManager.LoadScene("WorkoutListScene");

        Debug.Log("Workout Saved!");
    }
}