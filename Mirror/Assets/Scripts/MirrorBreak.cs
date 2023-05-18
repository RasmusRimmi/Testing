using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorBreak : MonoBehaviour
{
    public LevelManager cleared;
    public GameObject[] levels;
    public Sprite[] brokenMirror;

    // Update is called once per frame
    void Update()
    {
        for (int i = 4; i <= 13; i++)
        {
            int index = i - 4;  // Adjust the index to match the array

            if (cleared.levelCleared[i])
            {
                levels[index].GetComponent<SpriteRenderer>().sprite = brokenMirror[index / 1];
            }
        }
    }
}