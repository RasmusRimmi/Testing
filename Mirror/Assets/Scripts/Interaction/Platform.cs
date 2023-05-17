using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            collision.gameObject.transform.SetParent(transform);
        }

        if (collision.gameObject.name == "Player2")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            collision.gameObject.transform.SetParent(null);
        }

        if (collision.gameObject.name == "Player2")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }  
}
