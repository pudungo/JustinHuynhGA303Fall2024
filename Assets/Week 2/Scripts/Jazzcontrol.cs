using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jazzcontrol : MonoBehaviour
{
    public GameObject Jazz1;
    public GameObject Jazz2;
    public GameObject Jazz3;
    public GameObject Jazz4;
    public GameObject Jazz5;

    // Start is called before the first frame update
    void Start()
    {
        Jazz2.gameObject.SetActive(false);
        Jazz3.gameObject.SetActive(false);
        Jazz4.gameObject.SetActive(false);
        Jazz5.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Jazz1.gameObject.SetActive(false);
            Jazz3.gameObject.SetActive(false);
            Jazz4.gameObject.SetActive(false);
            Jazz5.gameObject.SetActive(false);
            Jazz2.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Jazz1.gameObject.SetActive(false);
            Jazz2.gameObject.SetActive(false);
            Jazz4.gameObject.SetActive(false);
            Jazz5.gameObject.SetActive(false);
            Jazz3.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Jazz1.gameObject.SetActive(false);
            Jazz2.gameObject.SetActive(false);
            Jazz3.gameObject.SetActive(false);
            Jazz5.gameObject.SetActive(false);
            Jazz4.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Jazz1.gameObject.SetActive(false);
            Jazz2.gameObject.SetActive(false);
            Jazz3.gameObject.SetActive(false);
            Jazz4.gameObject.SetActive(false);
            Jazz5.gameObject.SetActive(true);
        }
        void resetSprite()
        {
            Jazz1.gameObject.SetActive(true);
            Jazz2.gameObject.SetActive(false);
            Jazz3.gameObject.SetActive(false);
            Jazz4.gameObject.SetActive(false);
            Jazz5.gameObject.SetActive(false);
        }
    }
}
