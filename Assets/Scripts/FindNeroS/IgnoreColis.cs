using UnityEngine;

public class IgnoreCloneCollisions : MonoBehaviour
{
    void Start()
    {
        Collider thisCollider = GetComponent<Collider>();
        GameObject[] clones = GameObject.FindGameObjectsWithTag("Vergil");

        foreach (GameObject clone in clones)
        {
            Collider cloneCollider = clone.GetComponent<Collider>();
            if (cloneCollider != thisCollider)
            {
                Physics.IgnoreCollision(thisCollider, cloneCollider);
            }
        }
    }
}
