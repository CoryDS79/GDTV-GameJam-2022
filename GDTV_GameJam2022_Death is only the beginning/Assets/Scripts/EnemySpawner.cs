using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    Boss boss;
    BossSpawner bossSpawner;
    GunshipSpawner gunshipSpawner;
    FighterSpawner fighterSpawner;

    // Start is called before the first frame update
    void Start()
    {
        boss = FindObjectOfType<Boss>();
        bossSpawner = FindObjectOfType<BossSpawner>();
        gunshipSpawner = FindObjectOfType<GunshipSpawner>();
        fighterSpawner = FindObjectOfType<FighterSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bossSpawner.bossIsActive == false)
        {
            gunshipSpawner.SpawnGunships();
            fighterSpawner.SpawnFighters();
        }
        
    }
}
