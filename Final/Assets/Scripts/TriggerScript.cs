using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TriggerScript : MonoBehaviour
{
    public UnityEvent OnEnter, OnExit;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "KW")
        {
            OnEnter.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "KW")
        {
            OnEnter.Invoke();
        }
    }

}
