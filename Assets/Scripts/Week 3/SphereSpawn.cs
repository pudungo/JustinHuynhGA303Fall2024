using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawn : MonoBehaviour
{
    public GameObject sphere;
    public Transform sphereSpawnLocation;
    public float sphereSpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            GameObject go = Instantiate(sphere, sphereSpawnLocation.position, sphereSpawnLocation.rotation);

            go.GetComponent<Rigidbody>().AddForce(go.transform.up * sphereSpeed);

        }
    }
}