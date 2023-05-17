using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class Scoring : MonoBehaviour
{
    public LevelClear clear;

    [SerializeField] private FloatSO ScoreSO;
    [SerializeField] private LevelManager level;

    [SerializeField] private int CurrentLevelIndex;

    private void Start()
    {
        level.InitializeLevelClearStatuses(SceneManager.sceneCountInBuildSettings);

        level.LoadFromPlayerPrefs();

        CurrentLevelIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void Update()
    {
        if (clear.cleared == true && !level.levelCleared[CurrentLevelIndex])
        {
            ScoreSO.Value += 1;

            level.levelCleared[CurrentLevelIndex] = true;

            level.SaveToPlayerPrefs();

            clear.LevelComplete();
        }

        else if (clear.cleared == true && level.levelCleared[CurrentLevelIndex])
        {
            clear.LevelComplete();
        }
    }
}
