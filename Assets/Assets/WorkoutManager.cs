using UnityEngine;
using TMPro;

public class WorkoutManager : MonoBehaviour
{
    public TMP_InputField workoutInput;
    public TMP_InputField notesInput;

    public void SaveWorkout()
    {
        PlayerPrefs.SetString("WorkoutName", workoutInput.text);
        PlayerPrefs.SetString("WorkoutNotes", notesInput.text);
        PlayerPrefs.Save();
    }
}