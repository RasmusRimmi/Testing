using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalFixed : MonoBehaviour
{
    public FloatSO score;
    public GameObject portal;
    public Sprite portalFixed;

    // Update is called once per frame
    void Update()
    {
        if(score.Value == 10)
        {
            portal.GetComponent<SpriteRenderer>().sprite = portalFixed;
        }
    }
}
