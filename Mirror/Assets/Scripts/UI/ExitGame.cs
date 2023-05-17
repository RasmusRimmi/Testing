using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void QuitGame()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Application.Quit();
            Debug.Log("quit");
        }
    }

}
