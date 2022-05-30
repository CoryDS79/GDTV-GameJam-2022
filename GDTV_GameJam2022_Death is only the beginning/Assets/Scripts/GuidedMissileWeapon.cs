using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuidedMissileWeapon : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] GameObject[] firePointArray;
    [SerializeField] float rateOfFire;
    [SerializeField] float projectileSpeed;
    private float shotTimer = 0f;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Fire();
    }

    void CreateBullets() // Generate Bullets
    {
        if (player != null)
        {
            for (int i = 0; i < firePointArray.Length; i++)
            {
                GameObject guidedMissile = Instantiate(projectilePrefab, firePointArray[i].transform.position, Quaternion.identity);
            }
        }

    }

    public void Fire() // Countdown and fire at a steady rate
    {
        shotTimer += Time.deltaTime;
        if (shotTimer >= rateOfFire)
        {
            CreateBullets();
            shotTimer = 0;
        }

    }
}
