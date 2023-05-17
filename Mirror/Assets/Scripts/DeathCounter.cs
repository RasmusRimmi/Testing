using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathCounter : MonoBehaviour
{
    public TextMeshProUGUI deathCounter;

    public float deaths;


    // Start is called before the first frame update
    void Start()
    {
        deaths = 0;
        deathCounter.text = deaths.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        deathCounter.text = deaths.ToString();
    }
}
