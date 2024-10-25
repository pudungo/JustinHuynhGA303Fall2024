using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollsionChk : MonoBehaviour
{
    public GameObject cannonBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision otherObject) 
    {
        if (otherObject.collider.gameObject.tag == "cannonBallTag")
        {
            Debug.Log("Now that's a knuckleball!!");
           
        }
        if (otherObject.collider.gameObject.tag == "cannonBall2Tag")
        {
            Debug.Log("Dang that throw sucks!");
        }

    }
}
