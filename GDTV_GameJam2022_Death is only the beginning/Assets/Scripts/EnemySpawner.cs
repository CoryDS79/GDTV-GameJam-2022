using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject bossPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnBoss", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBoss()
    {
        Instantiate(bossPrefab, new Vector2(0, 11f), Quaternion.identity);
    }
}
