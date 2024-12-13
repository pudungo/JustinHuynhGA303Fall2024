using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object colliding is tagged as "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Parent the player to the platform
            collision.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Check if the object exiting is tagged as "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Unparent the player from the platform
            collision.transform.SetParent(null);
        }
    }
}
