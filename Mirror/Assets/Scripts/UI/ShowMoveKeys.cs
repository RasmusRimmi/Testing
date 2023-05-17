using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMoveKeys : MonoBehaviour
{
    public GameObject Controls;

    private void OnTriggerStay2D(Collider2D collision)
    {
        Controls.SetActive(true);
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    Controls.SetActive(false);
    //}
}
