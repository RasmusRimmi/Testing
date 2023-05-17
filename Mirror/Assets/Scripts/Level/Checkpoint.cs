using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform currentCheckpoint;
    public Player1Controller player1;
    public Player2Controller player2;

    public GameObject[] tutorials;

    /// <summary>
    /// Respawns characters to the current checkpoint
    /// </summary>
    public void Respawn()
    {
        player1.transform.position = new Vector3(currentCheckpoint.position.x, 8, currentCheckpoint.position.z);
        player2.transform.position = new Vector3(currentCheckpoint.position.x, -8, currentCheckpoint.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Checkpoint")
        {
            currentCheckpoint = collision.transform;
            collision.GetComponent<Collider2D>().enabled = false;

            if (currentCheckpoint.name == "Checkpoint1")
            {
                tutorials[0].SetActive(true);
            }

            else if (currentCheckpoint.name == "Checkpoint2")
            {
                tutorials[1].SetActive(true);
            }

            else if (currentCheckpoint.name == "Checkpoint3")
            {
                tutorials[2].SetActive(true);
            }
        }
    }
}
