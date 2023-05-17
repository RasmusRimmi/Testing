using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelClearStatus : MonoBehaviour
{
    public int levelIndex;

    private bool _isLevelClear = false;
    public bool IsLevelClear
    {
        get { return _isLevelClear; }
        set
        {
            _isLevelClear = value;
            SaveLevelClearStatus();
        }
    }

    private string GetPlayerPrefsKey()
    {
        return "LevelClearStatus_" + levelIndex;
    }

    private void Awake()
    {
        LoadLevelClearStatus();
    }

    private void SaveLevelClearStatus()
    {
        PlayerPrefs.SetInt(GetPlayerPrefsKey(), _isLevelClear ? 1 : 0);
        PlayerPrefs.Save();
    }

    private void LoadLevelClearStatus()
    {
        _isLevelClear = PlayerPrefs.GetInt(GetPlayerPrefsKey(), 0) == 1;
    }
}
