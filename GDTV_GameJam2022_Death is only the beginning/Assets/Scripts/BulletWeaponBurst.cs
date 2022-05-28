using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWeaponBurst : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject[] firePointArray;
    [SerializeField] float rateOfFire;
    [SerializeField] float projectileSpeed;
    [SerializeField] int burstSize;
    private float shotTimer = 0f;
    TargetPlayer targetPlayer;
    Player player;


    // Start is called before the first frame update
    void Start()
    {
        targetPlayer = FindObjectOfType<TargetPlayer>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Fire();
    }

    void CreateBullets() // Create 3 spaced out bullets
    {
        if (player != null)
        {
            for (int j = 0; j < burstSize; j++) // Run 3 times
            {
                for (int i = 0; i < firePointArray.Length; i++) // Create bullet
                {
                    GameObject targetedBullet = Instantiate(bulletPrefab, firePointArray[i].transform.position, Quaternion.identity);
                    targetedBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(targetPlayer.GetPlayerLocation().x, targetPlayer.GetPlayerLocation().y) * projectileSpeed;
                }
            }
        }

    }

    void Fire() // Countdown and fire at a steady rate
    {
        shotTimer += Time.deltaTime;
        if (shotTimer >= rateOfFire)
        {
            CreateBullets();
            shotTimer = 0;
        }

    }

}
