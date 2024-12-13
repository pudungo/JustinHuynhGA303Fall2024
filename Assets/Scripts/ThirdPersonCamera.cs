using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target; // The character the camera follows
    public float rotationSpeed = 5f; // Speed of camera rotation
    public float distance = 5f; // Distance from the character
    public float height = 2f; // Height above the character
    public float smoothTime = 0.1f; // Smoothness of camera movement
    public Vector2 pitchMinMax = new Vector2(-30, 60); // Min/Max pitch limits for vertical camera rotation

    private float currentRotationAngle = 0f; // Current angle of camera around target (Y-axis)
    private float currentHeight = 0f; // Current height of camera
    private float currentPitch = 0f; // Current pitch (vertical angle)
    private Vector3 currentVelocity; // Smooth velocity for camera movement

    private Camera cam;

    void Start()
    {
        // Get the camera component attached to the GameObject
        cam = GetComponentInChildren<Camera>();
        currentRotationAngle = target.eulerAngles.y; // Set initial rotation based on the target's Y rotation
        currentHeight = height;
    }

    void Update()
    {
        // Handle camera rotation based on mouse input
        float horizontalInput = Input.GetAxis("Mouse X");
        float verticalInput = Input.GetAxis("Mouse Y");

        currentRotationAngle += horizontalInput * rotationSpeed;
        currentPitch -= verticalInput * rotationSpeed;
        currentPitch = Mathf.Clamp(currentPitch, pitchMinMax.x, pitchMinMax.y);

        // Move the camera smoothly to follow the target's position
        Vector3 desiredPosition = target.position - (Quaternion.Euler(0, currentRotationAngle, 0) * Vector3.forward * distance);
        desiredPosition.y = target.position.y + currentHeight;

        // Smoothly move the camera to the desired position
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref currentVelocity, smoothTime);

        // Make sure the camera always looks at the target
        transform.LookAt(target.position + Vector3.up * 1f);
    }
}
