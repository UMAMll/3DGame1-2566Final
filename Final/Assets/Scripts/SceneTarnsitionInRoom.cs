using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SceneTarnsitionInRoom: MonoBehaviour
{
    public UnityEvent F_click;
    public UnityEvent ReportQuest;



    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            F_click.Invoke();
            gameObject.SetActive(false);
            return;
        }
        return;
    }
    
}
