using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reset : MonoBehaviour
{
    public FloatSO scoreSO;
    public LevelManager levelManager;
    public TextMeshProUGUI scoreText;
    public GameObject[] levels;
    public Sprite[] fixedMirror;
    public GameObject Portal;
    public Sprite emptyPortal;

    // Update is called once per frame
    void Update()
    {
        //If player press f9 game resets saved data
        if (Input.GetKeyDown(KeyCode.F9))
        {
            levelManager.ResetLevelClearStatuses();
            scoreSO.Value = 0;
            scoreText.text = scoreSO.Value + "/10";
            Portal.GetComponent<SpriteRenderer>().sprite = emptyPortal;

            for (int i = 4; i <= 13; i++)
            {
                int index = i - 4;  // Adjust the index to match the array

                levels[index].GetComponent<SpriteRenderer>().sprite = fixedMirror[index / 1];
            }
        }
    }
}
