using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWeapon : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject[] firePointArray;
    [SerializeField] float rateOfFire;
    [SerializeField] float projectileSpeed;
    private float shotTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    void CreateBullets() // Generate Bullets
    {
        for (int i = 0; i < firePointArray.Length; i++)
        {
            GameObject genericBullet = Instantiate(bulletPrefab, firePointArray[i].transform.position, Quaternion.identity);
            genericBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * - projectileSpeed;
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
