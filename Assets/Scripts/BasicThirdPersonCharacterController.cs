using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicThirdPersonCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;       // Speed of forward movement
    public float rotationSpeed = 720f; // Speed of rotation (degrees per second)

    public Animator animator;          // Reference to the Animator component
    private Vector3 movementDirection; // Stores movement direction
    private bool isWalkingBackwards;   // Bool to track backward movement

    // Update is called once per frame
    void Update()
    {
        // Handle movement input
        float horizontal = Input.GetAxis("Horizontal"); // A and D keys or arrow keys (left-right)
        float vertical = Input.GetAxis("Vertical");     // W and S keys or arrow keys (forward-backward)

        // Adjust movement speed for backward movement (S key)
        float currentSpeed = vertical < 0 ? moveSpeed * 0.5f : moveSpeed; // 50% speed when moving backward

        // Set the isWalkingBackwards boolean based on input
        isWalkingBackwards = vertical < 0;

        // Move the character forward and backward
        movementDirection = new Vector3(0, 0, vertical).normalized;

        // Rotate the character with A and D keys (or left-right arrow keys)
        if (horizontal != 0)
        {
            transform.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);
        }

        // Handle movement and animations
        if (movementDirection.magnitude > 0)
        {
            if (isWalkingBackwards)
            {
                animator.SetBool("isWalkingBackwards", true);  // Trigger walk backward animation
                animator.SetBool("isWalking", false);          // Ensure forward walking is off
            }
            else
            {
                animator.SetBool("isWalkingBackwards", false); // Disable walk backward animation
                animator.SetBool("isWalking", true);           // Trigger walking forward animation
            }

            transform.Translate(movementDirection * currentSpeed * Time.deltaTime);
        }
        else
        {
            // When not moving, reset both walking animations
            animator.SetBool("isWalking", false);
            animator.SetBool("isWalkingBackwards", false);
        }
    }
}
