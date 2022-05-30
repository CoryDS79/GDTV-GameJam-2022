using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    Boss boss;
    BossSpawner bossSpawner;
    GunshipSpawner gunshipSpawner;
    FighterSpawner fighterSpawner;
    bool dialogue;
    private float enemyTimer;
    [SerializeField] private float enemySpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        enemyTimer = 0f;
        boss = FindObjectOfType<Boss>();
        bossSpawner = FindObjectOfType<BossSpawner>();
        gunshipSpawner = FindObjectOfType<GunshipSpawner>();
        fighterSpawner = FindObjectOfType<FighterSpawner>();
        dialogue = FindObjectOfType<Dialogue>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogue = FindObjectOfType<Dialogue>() == true)
        {
            SpawnEnemies();
        }


    }

    private void EnemySpawnDuration()
    {
        enemyTimer += Time.deltaTime;
        //Debug.Log(Mathf.Round(enemyTimer));

        if (enemyTimer >= enemySpawnTime)
        {
            bossSpawner.bossWaveCount += 1;
            bossSpawner.SpawnBoss(bossSpawner.bossWaveCount);
            enemyTimer = 0;
        }


    }

    private void SpawnEnemies()
    {
        if (bossSpawner.bossIsActive == false)
        {
            gunshipSpawner.SpawnGunships();
            fighterSpawner.SpawnFighters();
            EnemySpawnDuration();
        }
    }
}
