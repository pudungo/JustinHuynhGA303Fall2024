using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Raycast : MonoBehaviour
{
    public Transform cameraTransform;
    [SerializeField] Inventory.AllItems requiredItem;


    // Start is called before the first frame update
    void Start()
    {

    }



        // Update is called once per frame
        void Update()
        {
            Debug.DrawRay(cameraTransform.position, cameraTransform.forward);
            if (Input.GetKeyDown(KeyCode.E))
            {
                RaycastHit hit;
            
             if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit))
                {
                    Debug.Log(hit.collider.gameObject.name);
                 {
                    if (hit.collider.tag == "RedDoor" && HasRequiredItem(Inventory.AllItems.KeyRed))
                    {

                            Debug.Log("Door OPEN!");
                            hit.collider.gameObject.GetComponent<Transform>().transform.position = Vector3.one;

                    }
                    else if (hit.collider.tag == "RedDoor")
                    {
                            Debug.Log("Door LOCKED");
                        
                    }
                    if (hit.collider.tag == "BlueDoor" && HasRequiredItem(Inventory.AllItems.KeyBlue))
                    {

                        Debug.Log("Door OPEN!");
                        hit.collider.gameObject.GetComponent<Transform>().transform.position = Vector3.one;

                    }
                    else if (hit.collider.tag == "BlueDoor")
                    {
                        Debug.Log("Door LOCKED");

                    }
                    if (hit.collider.tag == "GreenDoor" && HasRequiredItem(Inventory.AllItems.KeyGreen))
                    {

                        Debug.Log("Door OPEN!");
                        hit.collider.gameObject.GetComponent<Transform>().transform.position = Vector3.one;

                    }
                    else if (hit.collider.tag == "GreenDoor")
                    {
                        Debug.Log("Door LOCKED");

                    }

                }
                }
            }
        }
    public bool HasRequiredItem(Inventory.AllItems requiredItem)
    {
        if (Inventory.Instance._inventoryItems.Contains
            (requiredItem))
        {
            return true;
        }
        else
        {
            return false;
        }
    } }
