using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deliver2 : MonoBehaviour
{
    public GameObject Background;
    public GameObject Canvas;
    public float swapTime;
    // Start is called before the first frame update
    void Start()
    {
        swapTime = +1f;

        Debug.Log("Swap time from 1 sec to 2 sec.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
