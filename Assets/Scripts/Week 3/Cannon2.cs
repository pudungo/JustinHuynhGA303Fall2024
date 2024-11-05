using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon2 : MonoBehaviour
{
    public GameObject cannonBall2;
    public Transform cannonBallSpawnLocation2;
    public float cannonBall2Speed = 1000f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject go = Instantiate(cannonBall2, cannonBallSpawnLocation2.position, cannonBallSpawnLocation2.rotation);

            go.GetComponent<Rigidbody>().AddForce(go.transform.up * cannonBall2Speed);

        }
    }
}