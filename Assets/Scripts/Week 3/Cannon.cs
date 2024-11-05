using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonBall;
    public Transform cannonBallSpawnLocation;
    public float cannonBallSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(3))
        {
            GameObject go = Instantiate(cannonBall, cannonBallSpawnLocation.position, cannonBallSpawnLocation.rotation);

            go.GetComponent<Rigidbody>().AddForce(go.transform.right * cannonBallSpeed);

        }
    }
}
