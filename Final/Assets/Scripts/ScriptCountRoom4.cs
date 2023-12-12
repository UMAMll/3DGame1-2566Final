using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptCountRoom4 : MonoBehaviour
{
    public TextMeshProUGUI QuestText;
    public TextMeshProUGUI QuestTextcom;

    void Update()
    {
        QuestText.text = "เรียงเก้าอี้แล้ว   " + GameCountStd.currantstudentCount.ToString() + " / " + GameCountStd.MaxstudentCount.ToString();
        QuestTextcom.text = "เรียงเก้าอี้แล้ว   " + GameCountStd.currantstudentCount.ToString() + " / " + GameCountStd.MaxstudentCount.ToString();
    }
}
