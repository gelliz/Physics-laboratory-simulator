using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour
{
    [SerializeField]
    TMP_Text panel;

    [SerializeField]
    TMP_Text voltmeter;

    private void OnMouseDown()
    {
        panel.text = "30";
        voltmeter.text = "35.7";
        EventManager.PanelManager();
    }
}
