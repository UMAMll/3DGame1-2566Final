using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextCountScript : MonoBehaviour
{
    public TextMeshProUGUI QuestText;
    public TextMeshProUGUI QuestTextcom;

    void Update()
    {
        QuestText.text = "เรียกเพื่อนแล้ว   " + GameCountStd.currantstudentCount.ToString() + " / " + GameCountStd.MaxstudentCount.ToString();
        QuestTextcom.text = "เรียกเพื่อนแล้ว   " + GameCountStd.currantstudentCount.ToString() + " / " + GameCountStd.MaxstudentCount.ToString();
    }
}
