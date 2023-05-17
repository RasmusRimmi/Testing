using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalZechi : MonoBehaviour
{
    public bool zechiGoal = false;

    public GoalZechi goal;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            zechiGoal = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            zechiGoal = false;
        }
    }

}
