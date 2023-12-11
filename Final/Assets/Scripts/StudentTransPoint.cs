using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentTransPoint : MonoBehaviour
{
    public GameObject Position_End;
    
    public void Setposition()
    {
        transform.position = Position_End.transform.position;
        transform.rotation = Position_End.transform.rotation;
    }
}
