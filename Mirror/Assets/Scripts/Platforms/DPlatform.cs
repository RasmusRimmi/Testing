using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPlatform : MonoBehaviour
{
    public float timeToTogglePlatform = 2; // when the platform disappers
    public float currentTime = 0; 
    public new bool enabled = true;
    void Start()
    {
        enabled = true;
    }

    void Update()
    {
        currentTime += Time.deltaTime; // adds time
        if (currentTime >= timeToTogglePlatform) // when timer is less than 2 the platform appears
        {
            currentTime = 0; // where the timer starts
            TogglePlatform();
        }
    }
    void TogglePlatform()
    {
        enabled = !enabled; // if enabled was true it's now false
        foreach(Transform child in gameObject.transform) // disables the child, if not done in this way, the timer stops
        {
            child.gameObject.SetActive(enabled);
        }
    }
}
