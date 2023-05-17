using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UntagGoal2 : MonoBehaviour
{
    public GameObject goal;

    public static UntagGoal2 instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {

            gameObject.tag = "Untagged";
        }
    }
}
