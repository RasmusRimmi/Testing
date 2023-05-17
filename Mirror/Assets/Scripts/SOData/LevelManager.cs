using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu]
public class LevelManager : ScriptableObject
{
    //public bool levelClear = false;

    public bool[] levelCleared;

    private const string LevelClearStatusesKey = "LevelClearStatuses";

    string levelClearStatusesString;

    public void InitializeLevelClearStatuses(int levelCount)
    {
        levelCleared = new bool[levelCount];
    }

    public void LoadFromPlayerPrefs()
    {
        if (PlayerPrefs.HasKey(LevelClearStatusesKey))
        {
            string levelClearStatusesString = PlayerPrefs.GetString(LevelClearStatusesKey);
            string[] levelClearStatusesArray = levelClearStatusesString.Split(',');
            for (int i = 0; i < levelClearStatusesArray.Length; i++)
            {
                levelCleared[i] = (levelClearStatusesArray[i] == "1");
            }
        }
    }

    public void SaveToPlayerPrefs()
    {
        string levelClearStatusesString = string.Join(",", levelCleared.Select(s => s ? "1" : "0"));
        PlayerPrefs.SetString(LevelClearStatusesKey, levelClearStatusesString);
        PlayerPrefs.Save();
    }

    public void ResetLevelClearStatuses()
    {
        for (int i = 0; i < levelCleared.Length; i++)
        {
            levelCleared[i] = false;
        }

        SaveToPlayerPrefs();
    }
}
