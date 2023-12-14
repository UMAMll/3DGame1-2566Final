using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FClickEnterScripts : MonoBehaviour
{
    public UnityEvent TriggerKey;
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TriggerKey.Invoke();
        }
    }
}
