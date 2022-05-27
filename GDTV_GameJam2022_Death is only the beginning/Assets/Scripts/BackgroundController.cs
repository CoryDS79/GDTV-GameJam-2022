using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    Vector2 startPos;
    float repeatLength;
    [SerializeField] float parallax;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatLength = GetComponent<SpriteRenderer>().bounds.size.y;
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

}
