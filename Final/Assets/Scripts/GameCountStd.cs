using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameCountStd : MonoBehaviour
{
    public int Targetstudent;
    public static int countstudentnow;
    public static int currantstudentCount;
    public static int MaxstudentCount;

    public UnityEvent StdTarget;

    private void Start()
    {
        MaxstudentCount = Targetstudent;
        currantstudentCount = countstudentnow;
    }
    public void CountDown()
    {
        currantstudentCount++;
        countstudentnow = currantstudentCount;      
    }
    public void ChackCount()
    {
        if (currantstudentCount == MaxstudentCount)
        {
            StdTarget.Invoke();
        }
        else
            return;
    }

}
