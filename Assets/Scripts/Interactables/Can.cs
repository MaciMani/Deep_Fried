using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can : Interactions
{
    public GunData gun;
    [SerializeField]private int addAmmo;

    protected override void Interact()
    {
        if((gun.currentAmmo < gun.maxAmmo))
        {
            if (gun.currentAmmo + addAmmo > 100) gun.currentAmmo = 100;
            else gun.currentAmmo += addAmmo;
            Destroy(gameObject);
        }
    }
}
