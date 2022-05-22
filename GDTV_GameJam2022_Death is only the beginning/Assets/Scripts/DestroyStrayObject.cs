using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStrayObject : MonoBehaviour
{
    [SerializeField] float xBoundary = 7.5f;
    [SerializeField] float yBoundary = 9.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= yBoundary || transform.position.y <= -yBoundary || transform.position.x >= xBoundary || transform.position.x <= -xBoundary)
        {
            Destroy(gameObject);
        }
    }
}
