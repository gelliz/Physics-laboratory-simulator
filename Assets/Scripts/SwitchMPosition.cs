using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SwitchMPosition : MonoBehaviour
{
    [SerializeField]
    TMP_Text panel;

    [SerializeField]
    TMP_Text voltmeter;

    float newP = 0;
    float newV = 38.5f;

    //float min = -0.1f;
    //float max = 0.1f;

    float minAngle = 110;
    float maxAngle = 90;

    float speed = 5f;

    //float currentPos; 
    float currentAngle = 60;

    private enum State
    {
        off,
        on,
        turnToOff,
        turnToOn
    }

    State state = State.on;

    void OnEnable()//при включении/создании объекта
    {
        //currentPos = transform.localPosition.y;
        transform.rotation = Quaternion.Euler(new Vector3(0, 60, 0));
        EventManager.SwitchM += ChangeState;//подписались на событие 
    }

    void ChangeState(bool work)
    {
        if (work && state == State.off) state = State.turnToOn;
        else if (!work && state == State.on) state = State.turnToOff;
    }

    void FixedUpdate()
    {

        if (state == State.turnToOn)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0,60,0));
            state = State.on;

            float.TryParse(panel.text, out newP);
            newP += 10;
            panel.text = newP.ToString();

            
            newV += 3;
            voltmeter.text = newV.ToString();
        }

        if (state == State.turnToOff)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, -60, 0));

            state = State.off;

            
            newV += 10;
            voltmeter.text = newV.ToString();
        }
    }

}




