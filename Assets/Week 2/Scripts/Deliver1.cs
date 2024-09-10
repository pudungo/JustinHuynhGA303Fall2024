using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery1 : MonoBehaviour
{
    public GameObject Beat1;
    public GameObject Beat2;
    public GameObject Beat3;
    public GameObject Beat4;
    public GameObject Beat5;
    public float idleTimer;
    public float swapTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Beat2.gameObject.SetActive(false);
        Beat3.gameObject.SetActive(false);
        Beat4.gameObject.SetActive(false);
        Beat5.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (idleTimer > 0)
        {
            idleTimer -= Time.deltaTime;
            if (idleTimer < 0)
            {
                resetSprite();

            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Beat1.gameObject.SetActive(false);
            Beat3.gameObject.SetActive(false);
            Beat4.gameObject.SetActive(false);
            Beat5.gameObject.SetActive(false);
            Beat2.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Beat1.gameObject.SetActive(false);
            Beat2.gameObject.SetActive(false);
            Beat4.gameObject.SetActive(false);
            Beat5.gameObject.SetActive(false);
            Beat3.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Beat1.gameObject.SetActive(false);
            Beat2.gameObject.SetActive(false);
            Beat3.gameObject.SetActive(false);
            Beat5.gameObject.SetActive(false);
            Beat4.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Beat1.gameObject.SetActive(false);
            Beat2.gameObject.SetActive(false);
            Beat3.gameObject.SetActive(false);
            Beat4.gameObject.SetActive(false);
            Beat5.gameObject.SetActive(true);
        }
        void resetSprite()
        {
            Beat1.gameObject.SetActive(true);
            Beat2.gameObject.SetActive(false);
            Beat3.gameObject.SetActive(false);
            Beat4.gameObject.SetActive(false);
            Beat5.gameObject.SetActive(false);

        }
    }
}
