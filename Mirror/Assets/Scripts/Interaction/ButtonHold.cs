using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHold : MonoBehaviour
{
    public GameObject wallHold;
    public Sprite blue_button_up, blue_button_down;
    // while on top of the button disables the wall
    private void OnTriggerEnter2D(Collider2D collision)
    {
        wallHold.SetActive(false);

        this.gameObject.GetComponent<SpriteRenderer>().sprite = blue_button_down;
    }
}
