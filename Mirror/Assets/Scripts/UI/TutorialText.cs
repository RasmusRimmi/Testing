using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialText : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject tutorial;
    public GameObject controls;

    public Timer time;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartTutorialText();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    //if(textComponent.text == lines[index])
        //    //{
        //    //    NextLine();
        //    //}

        //    else
        //    {
        //        StopAllCoroutines();
        //        textComponent.text = lines[index];
        //    }
        //}

    }

    void StartTutorialText()
    {
        index = 0;

        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c  in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    //void NextLine()
    //{
    //    if(index < lines.Length - 1)
    //    {
    //        index++;
    //        textComponent.text = string.Empty;
    //        StartCoroutine(TypeLine());

    //        //if(tutorial.name == "Tutorial1" && index == 2)
    //        //{
    //        //    controls.SetActive(true);
    //        //}

    //        //else
    //        //{
    //        //    controls.SetActive(false);
    //        //}
    //    }

    //    else
    //    {
    //        gameObject.SetActive(false);
    //        time.startTimer = true;
    //    }
    //}
}
