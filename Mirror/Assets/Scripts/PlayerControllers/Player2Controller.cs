using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player2Controller : MonoBehaviour
{
    public float horizontal;
    public float speed;
    public float jumpingPower;
    public Animator animator;
    bool facingRight = true;

    public Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private float coyoteTime = 0.1f;
    private float coyoteTimeCounter;

    private float jumpBufferTime = 0.1f;
    private float jumpBufferCounter;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));

        if (Input.GetButtonDown("Jump"))
        {
            jumpBufferCounter = jumpBufferTime;
        }
        else
        {
            jumpBufferCounter -= Time.deltaTime;
        }

        if (coyoteTimeCounter > 0f && jumpBufferCounter > 0f)
        {
            rb.velocity = new Vector2(-rb.velocity.x, -jumpingPower);

            coyoteTimeCounter = 0f;

            jumpBufferCounter = 0f;

            animator.SetBool("IsJumping", true);
        }

        if (IsGrounded())
        {
            coyoteTimeCounter = coyoteTime;
        }

        else
        {
            coyoteTimeCounter -= Time.deltaTime;
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if (horizontal > 0 && !facingRight)
        {
            Flip();
        }
        if (horizontal < 0 && facingRight)
        {
            Flip();
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCapsule(groundCheck.position, new Vector2(0.69f, 0.1f), CapsuleDirection2D.Horizontal, 0, groundLayer);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("IsJumping", false);
        }

        if (other.gameObject.tag == "MovingPlatform")
        {
            rb.interpolation = RigidbodyInterpolation2D.None;
        }

        else
        {
            rb.interpolation = RigidbodyInterpolation2D.Interpolate;
        }

    }

    void Flip()
    {
        Vector3 currentscale = gameObject.transform.localScale;
        currentscale.x *= -1;
        gameObject.transform.localScale = currentscale;

        facingRight = !facingRight;
    }


    [Header("Events")]
    [Space]

    public UnityEvent OnLandEvent;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool>
    {

    }
}
