using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelClear : MonoBehaviour
{
    public GoalOni goalOni;
    public GoalZechi goalZechi;

    public bool cleared = false;
    [SerializeField] private FloatSO scoreSO;

    // Update is called once per frame
    void Update()
    {
        if (goalZechi.zechiGoal == true && goalOni.oniGoal == true)
        {
            cleared = true;
        }
    }

    public void LevelComplete()
    {

        SceneManager.LoadScene("levelSelect");
    }
}
