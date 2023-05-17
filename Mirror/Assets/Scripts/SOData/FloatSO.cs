using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class FloatSO : ScriptableObject
{
    [SerializeField]
    private float scoreValue;

    public float Value
    {
        get { return scoreValue; }
        set { scoreValue = value; }
    }

}
