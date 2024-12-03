using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float powerUpAmount;

    public PlayerRPG playerRPG;
    public Shooter shooter;

    public float timer;
    public float respawnTime;

    public MeshRenderer meshRenderer;
    public Collider objectCollider;

    public bool hasBeenPickedUp = false;

    public AudioSource pickUpSound;

    protected void Start()
    {
        playerRPG = FindFirstObjectByType<PlayerRPG>();
        shooter = FindFirstObjectByType<Shooter>();
        meshRenderer = GetComponent<MeshRenderer>();
        objectCollider = GetComponent<Collider>();
    }

    protected void Update()
    {
        if (hasBeenPickedUp == true)
        {
            timer += Time.deltaTime;
            if (timer >= respawnTime)
            {
                meshRenderer.enabled = true;
                objectCollider.enabled = true;

                timer = 0f;
                hasBeenPickedUp = false;

            }
        }

    }

    protected void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            PickUpPowerUp();
            pickUpSound.Play();
        }
    }

    protected virtual void PickUpPowerUp()
    {
        meshRenderer.enabled = false;
        objectCollider.enabled = false;
        hasBeenPickedUp = true;
        Debug.Log("Power Up is Picked Up");
    }
}
