using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class LevelFinish : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    public bool goal;
    public bool goal2;

    public LevelFinish upGoal, lowGoal;

    [SerializeField] private FloatSO scoreSO;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            goal = true;
        }
        if (other.CompareTag("Player2"))
        {
            goal2 = true;
        }

        if (upGoal.goal == true && lowGoal.goal2 == true)
        {
            LevelComplete();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            goal = false;
        }
        if (other.CompareTag("Player2"))
        {
            goal2 = false;
        }
    }
    public void LevelComplete()
    {
        SceneManager.LoadScene("levelSelect");

        transition.SetTrigger("Start");
    }
}
