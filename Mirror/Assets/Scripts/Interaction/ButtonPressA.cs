using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressA : MonoBehaviour
{
    public GameObject wallPress;
    // this button only needs to be pressed once and the wall appears
    private void OnTriggerEnter2D(Collider2D collision)
    {
        wallPress.SetActive(true);
    }
}
