using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform currentCheckpoint;
    public Player1Controller player1;
    public Player2Controller player2;

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
        }
    }
}
