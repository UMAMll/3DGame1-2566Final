using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class sceneTransition : MonoBehaviour
{
    public UnityEvent OnEnter, OnExit;


    private void OnTriggerEnter(Collider other)
    {
        OnEnter.Invoke();
    }
    private void OnTriggerExit(Collider other)
    {
        OnExit.Invoke();
    }
}