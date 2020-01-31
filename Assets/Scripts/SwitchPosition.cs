﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPosition : MonoBehaviour {


    //float min = -0.1f;
    //float max = 0.1f;

    float minAngle = 110;
    float maxAngle = 70;

    float speed = 5f;

    //float currentPos; 
    float currentAngle = 120;

    int tasknum;
    public void num(int ts)
    {
        tasknum = ts;
    }

    private enum State 
        {
        off,
        on,
        turnToOff,
        turnToOn
        }

    State state = State.off;

    void OnEnable()//при включении/создании объекта
    {
        //currentPos = transform.localPosition.y;
        EventManager.TaskNumber += num;
        EventManager.Switch += ChangeState;//подписались на событие 
    }
  
    void ChangeState(bool work)
    {
        if (work && state == State.off) state = State.turnToOn;
        else if (!work && state == State.on) state = State.turnToOff;
    }

    void FixedUpdate()
    {
        if (tasknum == 1||tasknum==30)
        {

            if (state == State.turnToOn)
            {
                currentAngle -= speed;
                if (currentAngle > maxAngle)
                {

                    transform.localRotation = Quaternion.AngleAxis(currentAngle, Vector3.right);
                }
                else state = State.on;

            }

            if (state == State.turnToOff)
            {
                currentAngle += speed;
                if (currentAngle < minAngle)
                {
                    transform.localRotation = Quaternion.AngleAxis(currentAngle, Vector3.right);
                }

                else state = State.off;

            }
        }
    }
    
}




