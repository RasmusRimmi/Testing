using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScore : Interaction
{
    bool interacted = false;
    public GameObject keyEnter;
    [SerializeField] private FloatSO ScoreSO;

    protected override void OnCollided(GameObject collidedObject)
    {
        base.OnCollided(gameObject);
        if(ScoreSO.Value >= 10)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                OnInteract();
            }
        }
    }

    protected virtual void OnInteract()
    {
        if (!interacted)
        {
            interacted = true;
        }
        string levelID = GetComponent<LevelSelector>().levelID;
        SceneManager.LoadScene(levelID);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ScoreSO.Value == 10)
        {
            keyEnter.SetActive(true);
        }

        else
        {
            keyEnter.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        keyEnter.SetActive(false);
    }
}
