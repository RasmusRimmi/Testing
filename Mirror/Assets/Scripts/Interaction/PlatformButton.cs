using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    public Platform platform;
    private int currentWaypointIndex = 0;

    [SerializeField] private float speed = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //platform.transform.position = Vector2.MoveTowards(platform.transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, platform.transform.position) < 1.5f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        platform.transform.position = Vector2.MoveTowards(platform.transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
