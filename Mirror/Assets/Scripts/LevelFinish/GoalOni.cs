using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalOni : MonoBehaviour
{
    public bool oniGoal = false;

    public GoalOni goal;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player2"))
        {
            oniGoal = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player2"))
        {
            oniGoal = false;
        }
    }
}
