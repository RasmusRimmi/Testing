using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour
{
    private Collider2D colliders;
    [SerializeField] private ContactFilter2D filter;
    private List<Collider2D> colliderObjects = new List<Collider2D>(1);

    protected virtual void Start()
    {
        colliders = GetComponent<Collider2D>();
    }

    protected virtual void Update()
    {
        colliders.OverlapCollider(filter, colliderObjects);
        foreach(var o in colliderObjects)
        {
            OnCollided(o.gameObject);
        }
    }

    protected virtual void OnCollided(GameObject collidedObject)
    {

    }
}
