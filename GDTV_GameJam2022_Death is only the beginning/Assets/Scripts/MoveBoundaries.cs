using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoundaries : MonoBehaviour
{
    [SerializeField] float xMin;
    [SerializeField] float xMax;
    [SerializeField] float yMin;
    [SerializeField] float yMax;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetBoundaries();
    }

    void SetBoundaries() // Confines play area
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMin, xMax), Mathf.Clamp(transform.position.y, yMin, yMax));
    }

}
