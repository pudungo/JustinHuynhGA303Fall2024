using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class LauncherScript : MonoBehaviour
{
    // Start is called before the first frame update
    public List<BodyLauncherScript> launchers = new List<BodyLauncherScript>();

    public int currentlySelectedLauncher = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            LaunchAllBodies();
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            MoveAllBodies();
        }
    }
    public void LaunchAllBodies()
    {
        
        for (int i = 0; i < launchers.Count; i++)

        {
            launchers[i].LaunchBody();
        }
    }
    public void MoveAllBodies()
    {
        List<Rigidbody> bodies = new List<Rigidbody>();

        foreach(GameObject go in GameObject.FindGameObjectsWithTag("waltz105"))
        {
            bodies.Add(go.GetComponent<Rigidbody>());
        }

        foreach (Rigidbody b in bodies)
        {
            if (b.gameObject.tag == "waltz105")
            {
                if (b.velocity.y == 0f)
                {
                    b.AddForce(Vector3.up * 2000f);
                }
            }
        }
    }
}
