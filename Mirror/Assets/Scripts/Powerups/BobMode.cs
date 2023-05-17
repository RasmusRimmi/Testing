using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobMode : MonoBehaviour
{
    private Vector2 BigMode = new Vector2(2f, 2f);
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player1")) 
        {
            Pickup(other);
        }
        else if (other.CompareTag("Player2"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider2D player)
    {
        player.transform.localScale = BigMode;

        Destroy(gameObject);
    }

}
