using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private FloatSO scoreSO;

    private Scene currentScene;

    [SerializeField] private LevelManager levelManager;

    private void Start()
    {
        scoreText = GameObject.Find("Collected").GetComponent<TextMeshProUGUI>();
        scoreText.text = scoreSO.Value + "/10";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            asdasdasdasd();
            
        }
        if  (Input.GetKeyDown(KeyCode.R) && currentScene.name != "LevelSelect")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("AreYouSure") && Input.GetKeyDown(KeyCode.Return))
        {
            Application.Quit();
            Debug.Log("Quit Game");
        }

        if (Input.GetKeyDown(KeyCode.F9))
        {
            levelManager.ResetLevelClearStatuses();
            scoreSO.Value = 0;
            scoreText.text = scoreSO.Value + "/10";

        }
    }

    void asdasdasdasd()
    {
        currentScene = SceneManager.GetActiveScene();
        
        if (currentScene.name == "LevelSelect")
        {
            SceneManager.LoadScene("AreYouSure");
        }

        else
        {
            SceneManager.LoadScene("LevelSelect");
        }

    }
}
