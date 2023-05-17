using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI time;

    private float timer;
    private string timePlayingStr;

    public GameObject[] tutorials;

    private TimeSpan timePlaying;
    public bool startTimer;

    // Start is called before the first frame update
    void Start()
    {
        time.text = "00:00:00";
        startTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
    }

    public void UpdateTime()
    {
        // Stop timer if any tutorial is active
        //foreach (GameObject tutorial in tutorials)
        //{
        //    if (tutorial.activeSelf == true)
        //    {
        //        startTimer = false;
        //        return;
        //    }
        //}

        //Start timer
        if (startTimer == true)
        {
            timer += Time.deltaTime;

            timePlaying = TimeSpan.FromSeconds(timer);
            timePlayingStr = timePlaying.ToString("mm':'ss':'ff");
            time.text = timePlayingStr;
        }

        //Show current time
        else
        {
            time.text = timePlayingStr;
        }
    }
}
