using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPowerUp : PowerUp
{
    protected override void PickUpPowerUp()
    {
        base.PickUpPowerUp();

        shooter.AddAmmo(powerUpAmount);
    }
}