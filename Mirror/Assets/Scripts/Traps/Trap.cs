using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    public Checkpoint checkpoint;

    public DeathCounter death;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        checkpoint.Respawn();
        death.deaths++;
    }
}
