using UnityEngine;
using TMPro;

public class DisplayWorkout : MonoBehaviour
{
    public TextMeshProUGUI workoutText;

    void Start()
    {
        string workout = PlayerPrefs.GetString("WorkoutName", "No workout");
        string notes = PlayerPrefs.GetString("WorkoutNotes", "No notes");

        workoutText.text = workout + "\n" + notes;
    }
}