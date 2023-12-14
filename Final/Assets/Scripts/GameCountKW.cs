using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameCountKW : MonoBehaviour
{
    public int TargetKW;
    public static int countKWnow;
    public static int currantKWCount;
    public static int MaxKWCount;

    public UnityEvent StdTarget;

    private void Start()
    {
        MaxKWCount = TargetKW;
        currantKWCount = countKWnow;
    }
    public void CountDown()
    {
        currantKWCount++;
        countKWnow = currantKWCount;      
    }
    public void ChackCount()
    {
        if (currantKWCount == MaxKWCount)
        {
            StdTarget.Invoke();
        }
        else
            return;
    }

}
