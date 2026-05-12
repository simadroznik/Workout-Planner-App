using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WorkoutCardUI : MonoBehaviour
{
    public TextMeshProUGUI workoutText;

    public Button deleteButton;
    public Button editButton;

    private Workout currentWorkout;

    public static Workout workoutToEdit;

    public void Setup(Workout workout)
    {
        currentWorkout = workout;

        workoutText.text =
            workout.dayOfWeek + "\n" +
            workout.workoutName + "\n" +
            workout.exercise;

        deleteButton.onClick.AddListener(DeleteWorkout);

        editButton.onClick.AddListener(EditWorkout);
    }

    void DeleteWorkout()
    {
        DisplayWorkout.workouts.Remove(currentWorkout);

        SaveSystem.SaveWorkouts(DisplayWorkout.workouts);

        Destroy(gameObject);
    }

    void EditWorkout()
    {
        workoutToEdit = currentWorkout;

        SceneManager.LoadScene("AddWorkoutScene");
    }
}