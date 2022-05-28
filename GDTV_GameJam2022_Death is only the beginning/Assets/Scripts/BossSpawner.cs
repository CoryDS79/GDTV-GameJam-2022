using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] bossPrefab;
    GameObject boss;
    private int bossWaveCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        SpawnBoss(bossWaveCount);
    }

    // Update is called once per frame
    void Update()
    {
        if (boss == null && bossWaveCount <= bossPrefab.Length)
        {
            bossWaveCount += 1;
            SpawnBoss(bossWaveCount);
        }
    }

    public void SpawnBoss(int index)
    {
        boss = Instantiate(bossPrefab[bossWaveCount], new Vector2(0, 11f), Quaternion.identity);
    }



}
