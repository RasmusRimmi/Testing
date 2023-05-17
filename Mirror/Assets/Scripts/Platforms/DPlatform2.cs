using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPlatform2 : MonoBehaviour
{
    public float timeToTogglePlatform = 2; 
    public float currentTime = 0;
    public new bool enabled = true;
    void Start()
    {
        enabled = true;
        currentTime = 2; // starting the timer at two seconds makes it so the platform is gone at the start
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= timeToTogglePlatform)
        {
            currentTime = 0;
            TogglePlatform();
        }
    }
    void TogglePlatform()
    {
        enabled = !enabled;
        foreach(Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(enabled);
        }
    }
}
