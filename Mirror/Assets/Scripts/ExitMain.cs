using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMain : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("AreYouSure");
        }
    }  
}