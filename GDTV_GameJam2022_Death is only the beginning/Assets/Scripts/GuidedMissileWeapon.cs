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
    TargetPlayer targetPlayer;

    // Start is called before the first frame update
    void Start()
    {
        targetPlayer = FindObjectOfType<TargetPlayer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Fire();
    }

    void CreateBullets() // Generate Bullets
    {
        for (int i = 0; i < firePointArray.Length; i++)
        {
            GameObject guidedMissile = Instantiate(projectilePrefab, firePointArray[i].transform.position, Quaternion.identity);
            // guidedMissile.transform.Translate(new Vector2(targetPlayer.GetPlayerLocation().x, targetPlayer.GetPlayerLocation().y) * projectileSpeed * Time.deltaTime); // Target player
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
