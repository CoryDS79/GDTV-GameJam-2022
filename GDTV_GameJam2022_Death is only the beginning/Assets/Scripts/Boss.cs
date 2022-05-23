using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    // [SerializeField] float rateOfFire;
    // private float shotTimer;
    // BulletWeapon bulletWeapon;
    // BulletWeaponBurst bulletWeaponBurst;

    // Start is called before the first frame update
    void Start()
    {
        // bulletWeapon = FindObjectOfType<BulletWeapon>();
        // bulletWeaponBurst = FindObjectOfType<BulletWeaponBurst>();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     ShootBullets(3);
    //     ShootBulletsBurst(5);
    // }

    // void ShootBullets(float rateOfFire) // Countdown and fire at a steady rate
    // {
    //     shotTimer += Time.deltaTime;
    //     if (shotTimer >= rateOfFire)
    //     {
    //         bulletWeapon.Fire();
    //         shotTimer = 0;
    //     }
    // }

    // void ShootBulletsBurst(float rateOfFire) // Countdown and fire at intervals
    // {
    //     shotTimer += Time.deltaTime;
    //     if (shotTimer >= rateOfFire)
    //     {
    //         bulletWeaponBurst.BurstFire();
    //         shotTimer = 0;
    //     }
    // }

    // float ShotTimer()
    // {
    //     shotTimer += Time.deltaTime;
    //     return shotTimer;
    // }
}
