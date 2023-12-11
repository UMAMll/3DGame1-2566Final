using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TalkSceneControllerScript : MonoBehaviour
{
    public UnityEvent Start, Stop;

    public void OnClick()
    {
        Start.Invoke();
    }
}
