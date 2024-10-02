using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyLauncherScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectile;
    public Transform projectileSpawnPosition;
    public float speed = 1000f;

    public void LaunchBody()
    {
        GameObject go = Instantiate(projectile, projectileSpawnPosition.position, projectileSpawnPosition.rotation);

        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
