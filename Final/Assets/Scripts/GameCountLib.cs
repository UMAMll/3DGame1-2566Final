using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameCountLib : MonoBehaviour
{
    public int Target;
    public  int countnow;
    public static int currantCount;
    public static int MaxCount;
    private void Start()
    {
        MaxCount = Target;
        currantCount = countnow;
    }
    public void CountDown()
    {
        currantCount++;
        countnow = currantCount;
    }

}
