using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    // Reference to the target the camera should follow
    public Transform target;

    // LateUpdate is called after all Update functions have been called, that the camera will change only after he almost get out of the screen
    void LateUpdate()
    {
        // Check if the target's y-position is higher than the camera's y-position
        if (target.position.y > transform.position.y)
        {
            // If true, create a new Vector3 with the same x and z positions as the camera,
            // but with the y position matching the target's y position
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);

            // Set the camera's position to the new position
            transform.position = newPos;
        }
    }
}
