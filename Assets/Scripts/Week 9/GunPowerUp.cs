using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPowerUp : PowerUp
{
    protected override void PickUpPowerUp()
    {
        base.PickUpPowerUp();

        shooter.AddDamage(powerUpAmount);
    }
}
