using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmmoUI : MonoBehaviour
{
    public Shooter shooter;
    public TextMeshProUGUI ammoText;

    void Start()
    {
        float value = shooter.ammo;
    }


    void Update()
    {
        ammoText.text = shooter.ammo.ToString("F1");
    }
}

