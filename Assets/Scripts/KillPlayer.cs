using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public Transform spawnLocation; // Set this to the desired respawn location in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the collider has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Move the player to the spawn location
            other.transform.position = spawnLocation.position;

            // Optional: Reset player velocity if using a Rigidbody
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }
}

