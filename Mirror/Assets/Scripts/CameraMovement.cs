using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera cam;
    private float horizontal;
    private Rigidbody2D rb;

    [Range(0.001f, 0.01f)]
    public float zoomOutSpeed;

    [Range(0.001f, 0.01f)]
    public float zoomInSpeed;

    public Player1Controller player1;
    public Player2Controller player2;

    public float bounds;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();           
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        CameraPosition();

        playerBounds();
    }

    private void LateUpdate()
    {
        if(player1.transform.position.y - player2.transform.position.y > 12 || player2.transform.position.y - player1.transform.position.y > 12)
        {
            //ZoomOut();
        }

        else
        {
            //ZoomIn();
        }
    }

    void CameraPosition()
    {
        if (transform.position.x >= -5.8f || transform.position.x <= 70f)
        {
            transform.position = Vector3.Lerp(player1.rb.position, player2.rb.position, 0.5f);
        }

        else if (transform.position.x < -5.8f)
        {
            Vector3 newPosition = new Vector3(-5.8f, transform.position.y, transform.position.z);
            transform.position = newPosition;
        }
    }

    public void ZoomOut()
    {
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 8, zoomOutSpeed);
    }

    public void ZoomIn()
    {
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 5.3f, zoomInSpeed);
    }

    public void playerBounds()
    {
        if (player1.transform.position.x - player2.transform.position.x > bounds)
        {
            if (player1.horizontal > 0)
            {
                player1.speed = 0;
            }

            if (player1.horizontal < 0)
            {
                player1.speed = 6;
            }

            if (player2.horizontal < 0)
            {
                player2.speed = 0;
            }

            if (player2.horizontal > 0)
            {
                player2.speed = 6;
            }
        }

        else if (player1.transform.position.x - player2.transform.position.x < 27 && player1.transform.position.x - player2.transform.position.x > -27)
        {         
            player1.speed = 6;         
        }

        if (player1.transform.position.x - player2.transform.position.x <= -bounds)
        {
            if (player1.horizontal < 0)
            {
                player1.speed = 0;
            }

            if (player1.horizontal > 0)
            {
                player1.speed = 6;
            }

            if (player2.horizontal > 0)
            {
                player2.speed = 0;
            }

            if (player2.horizontal < 0)
            {
                player2.speed = 6;
            }
        }

        else if (player1.transform.position.x - player2.transform.position.x > -bounds)
        {
            player1.speed = 6;
        }

        if (player2.transform.position.x - player1.transform.position.x > 27)
        {
            if (player2.horizontal > 0)
            {
                player2.speed = 0;
            }

            if (player2.horizontal < 0)
            {
                player2.speed = 6;
            }

            if (player1.horizontal < 0)
            {
                player1.speed = 0;
            }

            if (player1.horizontal > 0)
            {
                player1.speed = 6;
            }
        }

        if (player2.transform.position.x - player1.transform.position.x <= -bounds)
        {
            if (player2.horizontal < 0)
            {
                player2.speed = 0;
            }

            if (player2.horizontal > 0)
            {
                player2.speed = 6;
            }

            if (player1.horizontal > 0)
            {
                player1.speed = 0;
            }

            if (player1.horizontal < 0)
            {
                player1.speed = 6;
            }
        }

        else if (player2.transform.position.x - player1.transform.position.x < bounds)
        {
            player2.speed = 6;
        }
    }

}
