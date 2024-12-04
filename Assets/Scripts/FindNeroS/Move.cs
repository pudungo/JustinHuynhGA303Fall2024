using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Vector3 randomDirection = Random.onUnitSphere;
        randomDirection.z = 0;

        rb.velocity = randomDirection * speed;

        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Verts")
        {
            Vector3 reflectedVelocity = Vector3.Reflect(rb.velocity, collision.contacts[0].normal);
            rb.velocity = reflectedVelocity;
            Debug.Log("Collided with verts");

            
        }
        else if (collision.collider.tag == "Hors")
        {
            Vector3 reflectedVelocity = Vector3.Reflect(rb.velocity, collision.contacts[0].normal);
            rb.velocity = reflectedVelocity;
            Debug.Log("Collided with hors");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
