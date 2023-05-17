using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothFactor;
    
    public Vector3 minValues;
    public Vector3 maxValue;

    // Update is called once per frame
    void LateUpdate()
    {
        Follow();
    }

    public void Follow()
    {
        Vector3 playerPosition = player.position;
        
        //Verify if the targetPosition is out of bound or not
        //Limit it to the min and max values
        Vector3 boundPosition = new Vector3(
            Mathf.Clamp(playerPosition.x, minValues.x, maxValue.x),
            Mathf.Clamp(playerPosition.y, minValues.y, maxValue.y),
            Mathf.Clamp(playerPosition.z, minValues.z, maxValue.z));

        Vector3 smoothPosition = Vector3.Lerp(transform.position, boundPosition, smoothFactor * Time.deltaTime);
        transform.position = smoothPosition;
    }

}
