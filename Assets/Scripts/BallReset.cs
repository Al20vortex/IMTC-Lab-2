using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    private Vector3 initialPosition; // To store the initial position of the ball
    private Rigidbody rb;

    void Start()
    {
        // Save the ball's initial position at the start of the game
        initialPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // This function detects when the ball collides with another object
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object the ball collides with is tagged as "Grass Plane"
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Reset the ball to its initial position
            transform.position = initialPosition;
            // Zero out the ball's velocities (both linear and angular)
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    
}
