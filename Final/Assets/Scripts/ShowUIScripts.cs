using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShowUIScripts : MonoBehaviour
{
    public UnityEvent OnEnter, OnExit;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Cursor.lockState = false ? CursorLockMode.Locked : CursorLockMode.None;
            Cursor.visible = true;
            OnEnter.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Cursor.lockState = true ? CursorLockMode.Locked : CursorLockMode.None;
            Cursor.visible = false;
            OnExit.Invoke();
        }
            
    }

}
