using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentFun : MonoBehaviour
{
    public GameObject superCoolBallObject;

    public int counter = 0;
    public string myName;

    // Start is called before the first frame update
    void Start()
    {
        //superCoolBallObject = GameObject.Find("Spiderman"); //Find the GameObject in the Heirarchy named
        //"Spiderman" _EXACTLY_ and set a variable reference to "superCoolBallObject".
        //superCoolBallObject now always refers to the object that was found named Spiderman.

        
        //GameObject.Find("Sphere").transform.SetParent(null);
        superCoolBallObject.SetActive(false); //This sets the GameObject that is referred to by "superCoolBallObject" to disabled.
        superCoolBallObject.SetActive(true); ////This sets the GameObject that is referred to by "superCoolBallObject" to enabled.

        //gameObject.SetActive(false); //This would trun off the gameObject in the scene.
        //gameObject.SetActive(true); //This would turn on the gameObject in the scene.
        //gameObject.transform.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
