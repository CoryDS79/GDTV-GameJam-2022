using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    Vector2 startPos;
    float repeatLength;
    [SerializeField] float parallax;
    [SerializeField] float acceleration = 1f;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatLength = GetComponent<SpriteRenderer>().bounds.size.y;
        EventManager.JumpToHyperspace += HyperspaceSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * parallax * Time.deltaTime);


        if (transform.position.y < startPos.y - repeatLength)
        {
            transform.position = startPos;
        }
    }

    void HyperspaceSpeed()
    {
        parallax *= acceleration;
    }

    private void OnDisable()
    {
        EventManager.JumpToHyperspace -= HyperspaceSpeed;
    }

}
