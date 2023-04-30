using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GunData gunData;
    [SerializeField] private Transform muzzle;

    float timeSinceLastShot;

    private void Start()
    {
        PlayerShoot.shootInput += Shoot;
    }

    private bool CanShoot() => timeSinceLastShot > 1f / (gunData.fireRate / 60f);

    public void Shoot() 
    {
        if (gunData.currentAmmo > 0)
        {
            if (CanShoot())
            {
                if (Physics.Raycast(muzzle.position, muzzle.forward, out RaycastHit hitInfo, gunData.maxDistance))
                {
                    IDamageable damageable = hitInfo.transform.GetComponent<IDamageable>();
                    damageable?.TakeDamage(gunData.damage);
                    
                }
            }

            gunData.currentAmmo--;
            timeSinceLastShot = 0;
            //OnGunShot();
        }
    }

    private void Update() 
    {
        timeSinceLastShot += Time.deltaTime;

        Debug.DrawRay(muzzle.position, muzzle.forward * gunData.maxDistance);
    }

    
    /*
    private void OnGunShot() 
    {
        throw new NotImplementedException();
    }
    */
    
}
