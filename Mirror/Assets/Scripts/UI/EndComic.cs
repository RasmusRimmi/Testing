using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndComic : MonoBehaviour
{
    public GameObject[] comics;

    private void Awake()
    {
        comics[0].SetActive(true);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (comics[0].activeSelf)
            {
                comics[0].SetActive(false);
                comics[1].SetActive(true);
            }

            else if (comics[1].activeSelf)
            {
                comics[1].SetActive(false);
                comics[2].SetActive(true);
            }

            else if (comics[2].activeSelf)
            {
                comics[2].SetActive(false);
                comics[3].SetActive(true);
            }

            else if (comics[3].activeSelf)
            {
                comics[3].SetActive(false);
            }
        }

    }
}
