using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorScreen : MonoBehaviour
{
    [SerializeField] GameObject selector;

    [SerializeField] GameObject[] row1;

    [SerializeField] GameObject[] row2;

    [SerializeField] GameObject[] row3;

    const int columns = 3; // How many colums
    const int rows = 3; // How many rows

    Vector2 positionIndex;
    GameObject currentSlot;
    bool isMoving = false;

    public GameObject[,] grid = new GameObject[columns, rows]; // Declares 2D Grid

    void Start()
    {
        AddRowToGrid(0, row1);
        AddRowToGrid(1, row2);
        AddRowToGrid(2, row3);

        positionIndex = new Vector2(0, 0);
        currentSlot = grid[0, 0];

    }
    void AddRowToGrid(int index, GameObject[] row)
    {
        for (int i = 0; i < 3; i++)
        {
            grid[index, i] = row[i];
        }
    }
    void Update() // Movement
    {
        float xAis = Input.GetAxisRaw("Horizontal");
        float yAis = Input.GetAxisRaw("Vertical");

        if(xAis > 0) // Input right
        {
            MoveSelector("right");
        }
        else if(xAis < 0) // Input left
        {
            MoveSelector("left");
        }
        else if(yAis > 0) // Input up
        {
            MoveSelector("up");
        }
        else if(yAis < 0) // Input down
        {
            MoveSelector("down");
        }

        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            string levelID = currentSlot.GetComponent<LevelSelector>().levelID;
            SceneManager.LoadScene(levelID);
        }
    }

    void MoveSelector(string direction)
    {
        if(isMoving == false)
        {
            isMoving = true;

            if(direction == "right")
            {
                if (positionIndex.x < columns - 1)
                {
                    positionIndex.x += 1;
                }
            }
            else if (direction == "left")
            {
                if (positionIndex.x > 0)
                {
                    positionIndex.x -= 1;
                }
            }
            else if (direction == "up")
            {
                if (positionIndex.y > 0)
                {
                    positionIndex.y -= 1;
                }
            }
            else if (direction == "down")
            {
                if (positionIndex.y < rows - 1)
                {
                    positionIndex.y += 1;
                }
            }
            currentSlot = grid[(int)positionIndex.y, (int)positionIndex.x];
            selector.transform.position = currentSlot.transform.position;

            Invoke("ResetMoving", 0.2f);
        }
    }

    void ResetMoving()
    {
        isMoving = false;
    }
}
