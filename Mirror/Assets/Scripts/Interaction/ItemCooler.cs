using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCooler : MonoBehaviour
{
    public float amp;
    public float freq;
    Vector3 initialPos;

    private void Start()
    {
        initialPos = transform.position;
    }
    void Update()
    {
        transform.localPosition = new Vector3(initialPos.x, Mathf.Sin(Time.time * freq) * amp + initialPos.y, 0); // Makes items move up and down
    }
}
