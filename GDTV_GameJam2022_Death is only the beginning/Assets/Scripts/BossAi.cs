using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAi : MonoBehaviour
{
    [SerializeField] float speed;
    private float moveTimer;
    private float timeToMove = 5f;
    Vector2 newPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveAroundRandomly();
    }


    void MoveAroundRandomly()
    {
        moveTimer += Time.deltaTime;
        if (moveTimer >= timeToMove)
        {
            newPos = new Vector2 (Random.Range(-4, 4), Random.Range(-4, 4));
            moveTimer = 0;
        }
        transform.position = Vector2.MoveTowards(transform.position, newPos, speed * Time.deltaTime);

    }
}

