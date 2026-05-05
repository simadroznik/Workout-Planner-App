using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GoToHome()
    {
        SceneManager.LoadScene("HomeScene");
    }

    public void GoToWorkoutList()
    {
        SceneManager.LoadScene("WorkoutListScene");
    }

    public void GoToAddWorkout()
    {
        SceneManager.LoadScene("AddWorkoutScene");
    }
}