using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static event Action JumpToHyperspace;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        JumpToHyperpaceAction();
    }

    private static void JumpToHyperpaceAction()
    {
        // set the text component to be active

        if (Input.GetKeyDown(KeyCode.J))
        {
            JumpToHyperspace?.Invoke();
        }
    }
}
