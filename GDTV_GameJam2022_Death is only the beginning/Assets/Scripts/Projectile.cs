using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 1f;
    TargetPlayer targetPlayer;
    // Rigidbody2D myRb;

    // Start is called before the first frame update
    void Start()
    {
        targetPlayer = FindObjectOfType<TargetPlayer>();
        // myRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(new Vector2(0, 1) * -projectileSpeed * Time.deltaTime); // Fire downward
        // transform.Translate(new Vector2(targetPlayer.GetPlayerLocation().x, targetPlayer.GetPlayerLocation().y) * projectileSpeed * Time.deltaTime); // Target player
        // myRb.velocity = new Vector2(targetPlayer.GetPlayerLocation().x, targetPlayer.GetPlayerLocation().y) * projectileSpeed * Time.deltaTime; // Target player alt
        transform.position = Vector2.MoveTowards(transform.position, targetPlayer.GetPlayerLocation(), projectileSpeed * Time.deltaTime);
    }
}
