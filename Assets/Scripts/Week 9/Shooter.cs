using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletForce;
    public Transform bulletSpawnPosition;
    public float damage = 5f;
    public float ammo = 5f;

    public TextMeshProUGUI ammoText;

    public Camera playerCamera;
    public ParticleSystem muzzleFlash;
    public AudioSource shotgunSfx;

    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            Shoot();
            ammoText.text = ammo.ToString();
        }
    }

    void Shoot()
    {
        if (ammo > 0)
        {
            ammo--;

            muzzleFlash.Play();
            shotgunSfx.Play();

            RaycastHit hit;
            if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit))
            {
                Debug.Log(hit.transform.name);

                BaseEnemy target = hit.transform.GetComponent<BaseEnemy>();
                if (target != null)
                {
                    target.TakeDamage(damage);
                }
                GameObject bullet = Instantiate(bulletPrefab, hit.point, Quaternion.LookRotation(hit.normal));

                bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletForce);

                Destroy(bullet, 3f);


            }

        }
    }
    public void AddAmmo(float ammoAmount)
    {
        ammo += ammoAmount;
    }
    public void AddDamage(float damageAmount)
    {
        damage += damageAmount;
    }
}

