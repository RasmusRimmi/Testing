using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPrompt : MonoBehaviour
{
    public GameObject keyEnter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        keyEnter.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        keyEnter.SetActive(false);
    }
}
