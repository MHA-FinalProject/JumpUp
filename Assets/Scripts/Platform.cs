using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    // Jump force to apply when a GameObject lands on the platform to keep jumping
    public float jumpForce = 10f;

    // A private variable storing the value zero as a float
    private float zero = 0f;

    // Called when a 2D collider enters another collider
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the relative velocity along the y-axis is less than or equal to zero
        if (collision.relativeVelocity.y <= zero)
        {
            // Get the Rigidbody2D component of the colliding GameObject
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            // Check if the Rigidbody2D component is not null
            if (rb != null)
            {
                // Set the y-velocity of the Rigidbody2D to the specified jump force
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
    }
}
