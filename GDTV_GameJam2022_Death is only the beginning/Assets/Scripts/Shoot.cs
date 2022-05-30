using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject playerProjectilePrefab;
    [SerializeField] float projectileSpeed;
    bool dialogue;

    // Start is called before the first frame update
    void Start()
    {
        dialogue = FindObjectOfType<Dialogue>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (dialogue = FindObjectOfType<Dialogue>().dialogueEnded == true)
        {
            FireProjectile();
        }

    }

    void FireProjectile()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject playerLaser = Instantiate(playerProjectilePrefab, transform.position, Quaternion.identity);
            playerLaser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * projectileSpeed;
        }
    }
}
