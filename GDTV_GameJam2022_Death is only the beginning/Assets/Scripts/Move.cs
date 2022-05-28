using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        EnemyMove();
    }

    void PlayerMove()
    {
        if (this.CompareTag("Player"))
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * playerSpeed);
            transform.Translate(Vector2.up * verticalInput * Time.deltaTime * playerSpeed);
        }

    }

    void EnemyMove()
    {
        if (this.CompareTag("Enemy"))
        {
            transform.Translate(Vector2.down * enemySpeed * Time.deltaTime);
        }
    }
    
}
