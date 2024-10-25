using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeEventPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Updating every frame!");
    }

    private void LateUpdate()
    {
        Debug.Log("Updating every frame after after update!");
    }

    private void FixedUpdate()
    {
        Debug.Log("Updating 30 frames per second!");
    }

    void OnEnable() //called when the object is enable from a disabled state. (Called after start if object is active
    {
        Debug.Log("Object is enabled!");
    }

    void OnDisable() //calls all code in function right before its disabled
    {
        Debug.Log("Object is disabled!");
    }
}
