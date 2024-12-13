using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    public float moveSpeedMultiplier = 5f;
    public float strafeSpeedMultiplier = 4f;
    public float jumpForce = 5f;
    public Animator animator;
    public Rigidbody rb;
    public Transform cameraTransform;  // Reference to the camera

    private bool isGrounded = true;

    void Start()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody>();

        if (cameraTransform == null)
            cameraTransform = Camera.main.transform; // Default to main camera if not assigned
    }

    void Update()
    {
        // Capture movement input
        float move = Input.GetAxis("Vertical");     // Forward/Backward
        float strafe = Input.GetAxis("Horizontal"); // Left/Right Strafe

        // Calculate movement speeds
        float moveSpeed = move * moveSpeedMultiplier;
        float strafeSpeed = strafe * strafeSpeedMultiplier;

        // Apply movement to character
        Vector3 movement = transform.forward * moveSpeed * Time.deltaTime;
        Vector3 strafeMovement = transform.right * strafeSpeed * Time.deltaTime;
        transform.position += movement + strafeMovement;

        // Pass speeds to Animator for blend tree control
        animator.SetFloat("moveSpeed", moveSpeed);     // Includes forward and backward values
        animator.SetFloat("strafeSpeed", strafeSpeed); // Includes left and right values

        // Handle jumping
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            animator.SetBool("isJumping", true);
        }

        // Rotate the character to face the camera's direction horizontally
        RotateCharacterTowardsCamera();
    }

    // Rotate the character to face the camera's direction on the horizontal plane
    private void RotateCharacterTowardsCamera()
    {
        // Calculate the direction the camera is facing on the XZ plane (ignore vertical tilt)
        Vector3 cameraForward = cameraTransform.forward;
        cameraForward.y = 0;  // Ignore vertical rotation (y-axis)

        // Calculate the rotation needed to face the camera's direction
        Quaternion targetRotation = Quaternion.LookRotation(cameraForward);

        // Smoothly rotate the player towards the camera's direction
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
    }

    // Reset jump state on ground collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("isJumping", false);
        }
    }


}