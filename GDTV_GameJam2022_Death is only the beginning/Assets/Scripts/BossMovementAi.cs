using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovementAi : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] private float timeToMove = 5f;
    [SerializeField] Vector2 startPos = new Vector2(0, 0);
    private float moveTimer;
    Vector2 newRandomPos;


    // Start is called before the first frame update
    void Start()
    {
        newRandomPos = startPos;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ChooseRandomPosAtIntervals();
        MoveTowardsPosition(newRandomPos);
    }


    void ChooseRandomPosAtIntervals() // Timer to create random positions at intervals
    {
        moveTimer += Time.deltaTime;
        if (moveTimer >= timeToMove)
        {
            RandomizePosition();
            moveTimer = 0;
        }
    }

    private void MoveTowardsPosition(Vector2 target) // Moves to the target
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private Vector2 RandomizePosition() // Creates random target position
    {
        newRandomPos = new Vector2(Random.Range(-3.5f, 3.5f), Random.Range(0f, 4f));
        return newRandomPos;
    }

}

