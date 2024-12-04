using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Verts")
        {
            
            Debug.Log("Collided with verts");
        }
        else if (collision.collider.tag == "Hors")
        {
            Debug.Log("Collided with hors");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
