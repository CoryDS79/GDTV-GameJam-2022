using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 1f;
    TargetPlayer targetPlayer;

    // // Start is called before the first frame update
    void Start()
    {
        targetPlayer = FindObjectOfType<TargetPlayer>();
    }

    // // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPlayer.GetPlayerLocation(), projectileSpeed * Time.deltaTime);
    }
}
