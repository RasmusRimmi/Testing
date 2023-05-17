using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelInteraction : Interaction
{
    bool interacted = false;
    protected override void OnCollided(GameObject collidedObject)
    {
        base.OnCollided(gameObject);
        if (Input.GetKey(KeyCode.Return))
        {
            OnInteract();
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
}
