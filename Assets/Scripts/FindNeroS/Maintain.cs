using UnityEngine;

public class Maintain : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Optionally, set an initial velocity

    }

    void OnCollisionEnter(Collision collision)
    {
        // Ensure the velocity remains constant after collision
        Vector3 currentVelocity = rb.velocity * speed;

        // Optionally, log the collision for debugging
        Debug.Log("Collided with: " + collision.gameObject.name);

        // Reapply the velocity to maintain it
        rb.velocity = currentVelocity;
    }

    void OnCollisionStay(Collision collision)
    {
        // Ensure the velocity remains constant during the collision
        Vector3 currentVelocity = rb.velocity * speed;
        rb.velocity = currentVelocity;
    }

    void OnCollisionExit(Collision collision)
    {
        // Optionally, ensure the velocity is maintained after the collision
        Vector3 currentVelocity = rb.velocity * speed;
        rb.velocity = currentVelocity;
    }
}
