using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CurserModeSet : MonoBehaviour
{
    public UnityEvent AtlDown,AtlUp;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftAlt))
            AtlDown.Invoke();
        if (Input.GetKeyUp(KeyCode.LeftAlt))
            AtlUp.Invoke();
        
    }
}
