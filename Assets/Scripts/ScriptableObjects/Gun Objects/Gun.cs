using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gun : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GunData gunData;
    [SerializeField] private Transform cam;
    [SerializeField] private TextMeshProUGUI gunName;
    [SerializeField] private TextMeshProUGUI ammoCount;

    float timeSinceLastShot;
    
    private void Awake()
    {
        gunData.currentAmmo = gunData.maxAmmo;
    }

    private void OnEnable()
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
                if (Physics.Raycast(cam.position, cam.forward, out RaycastHit hitInfo, gunData.maxDistance))
                {
                    IDamageable damageable = hitInfo.transform.GetComponent<IDamageable>();
                    damageable?.TakeDamage(gunData.damage);
                    
                }
                gunData.currentAmmo--;
                timeSinceLastShot = 0;
                //OnGunShot();
            }
        }
    }

    private void Update() 
    {
        timeSinceLastShot += Time.deltaTime;

        Debug.DrawRay(cam.position, cam.forward * gunData.maxDistance);

        gunName.text = gunData.name;
        ammoCount.text = Convert.ToString(gunData.currentAmmo);
    }

    private void OnDisable()
    {
        PlayerShoot.shootInput -= Shoot;
    }


    /*
    private void OnGunShot() 
    {
        throw new NotImplementedException();
    }
    */

}
