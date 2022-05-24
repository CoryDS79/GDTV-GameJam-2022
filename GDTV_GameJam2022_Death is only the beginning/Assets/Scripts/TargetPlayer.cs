using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlayer : MonoBehaviour
{
    GameObject player;
    Vector2 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        TargetCurrentPlayerLocation();
        GetPlayerLocation();
    }

    private void TargetCurrentPlayerLocation()
    {
        if (player != null)
        {
            playerPos = player.transform.position;
        }
    }

    public Vector2 GetPlayerLocation()
    {
        // Debug.Log(playerPos);
        return playerPos;
    }
}
