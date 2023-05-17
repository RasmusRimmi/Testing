using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping1 : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] int jumpPower;

    public Transform groundCheck;
    public LayerMask groundLayer;
  

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space)) && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }

    }
    private bool isGrounded()
    {
        return Physics2D.OverlapCapsule(groundCheck.position, new Vector2(0.7f, 0.1f), CapsuleDirection2D.Horizontal, 0, groundLayer);
    }

}
