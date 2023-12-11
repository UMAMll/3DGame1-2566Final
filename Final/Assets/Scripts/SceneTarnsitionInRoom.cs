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
            //if (GameCountLib.currantCount == GameCountLib.MaxCount)
                F_click.Invoke();
            /*else
                ReportQuest.Invoke();
           return;*/
        }
        return;
    }
    
}
