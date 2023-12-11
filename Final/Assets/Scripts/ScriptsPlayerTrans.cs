using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ScriptsPlayerTrans : MonoBehaviour
{
    public UnityEvent F_click;
    public UnityEvent ReportQuest;
    public GameObject Check;


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (GameCountStd.currantstudentCount == GameCountStd.MaxstudentCount)
            {
                if (Check.active == false)
                    F_click.Invoke();
                else
                    ReportQuest.Invoke();
                    return;
            }
            else
                ReportQuest.Invoke();
                return; 
        }
    }

}

