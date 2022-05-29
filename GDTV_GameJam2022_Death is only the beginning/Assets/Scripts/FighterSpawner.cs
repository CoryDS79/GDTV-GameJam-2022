using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] enemyPrefab;
    [SerializeField] float spawnTimer = 0f;
    [SerializeField] float spawnRate;

    // Start is called before the first frame update
    void Start()
    {
        SpawnFighters();   
    }

    // Update is called once per frame
    void Update()
    {
        //SpawnFighters();
    }

    private void CreateFighters()
    {
        float randomXPos = Random.Range(-5f, 5f);

        for (int i = 0; i < 3; i++)
        {
            float enemySpeed = 2;
            GameObject fighter = Instantiate(enemyPrefab[0], new Vector2(randomXPos, 11f + i), Quaternion.identity);
            fighter.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * - enemySpeed;
        }

    }

    public void SpawnFighters() // Countdown and fire at a steady rate
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnRate)
        {
            CreateFighters();
            spawnTimer = 0;
        }

    }
}
