using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowJumpKey : MonoBehaviour
{
    public GameObject jumpControl;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        jumpControl.SetActive(true);
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    jumpControl.SetActive(false);
    //}
}
