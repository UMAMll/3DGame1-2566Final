using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IsTalkScript : MonoBehaviour
{
    public UnityEvent OnEnter, OnExit;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Player")
            OnEnter.Invoke();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            OnExit.Invoke();
    }
    
}
