using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputEvents : MonoBehaviour
{
    //public GameAction rightInputAction, leftInputAction, spaceInputAction;
    public UnityEvent rightInputEvent, leftInputEvent, spaceInputEvent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightInputEvent.Invoke();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftInputEvent.Invoke();
        }

        if (Input.GetButtonDown("Jump"))
        {
            spaceInputEvent.Invoke();
        }
    }
}
