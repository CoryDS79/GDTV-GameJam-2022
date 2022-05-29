using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunshipSpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnTimer = 0f;
    [SerializeField] float spawnRate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //SpawnGunships();
    }

    private void CreateGunships()
    {   float randomXPos = Random.Range(-3.5f, 3.5f);

        float enemySpeed = 3;
        GameObject fighter = Instantiate(enemyPrefab, new Vector2(randomXPos, 11f), Quaternion.identity);
        fighter.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * -enemySpeed;

    }

    public void SpawnGunships() // Countdown and fire at a steady rate
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnRate)
        {
            CreateGunships();
            spawnTimer = 0;
        }

    }
}
