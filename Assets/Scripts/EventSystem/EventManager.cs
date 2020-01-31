using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void SwitchHandler(bool work);//переключатель/включение установки
    public delegate void MoveHandler();//перемещние камеры к окуляру
    public delegate void MoveHandlerDoor(bool IsMove);
    public delegate void SwitchCamerasHandler(bool main);//смена камер
    public delegate void HandlerColorChanger(Color color);//поворот линзы
    public delegate bool HandlerValues();//запись в таблицу
    public delegate void Task(int task);//запись в таблицу

    public static event SwitchHandler Switch;//переключение
    public static event SwitchHandler SwitchM;//переключение
    public static event MoveHandler StartTxt;//переключение
    public static event MoveHandlerDoor MovingDoor;
    public static event MoveHandler Moved;//перемещение
    public static event SwitchCamerasHandler SwitchCan;//перемещение
    public static event HandlerColorChanger ColorChanger;//смена цвета
    public static event MoveHandler WritingValue;//смена цвета
    public static event Task TaskNumber;//смена цвета

    private void Start()
    {
        Switch(false);
    }

    public static void WhatTask(int task)
    {
        TaskNumber(task);
    }
    public static void PanelManager()//просто метод, который будет вызвать событие
    {
        StartTxt();
    }

    public static void SwitchWork(bool work)//просто метод, который будет вызвать событие
    {
        Switch(work);//вызываем событие для подписчиков
    }

    public static void SwitchMW(bool work)
    {
        SwitchM(work);
    }

    public static void MovedDoor(bool IsMove)
    {
        try
        {
            MovingDoor(IsMove);
        }
        catch { }
    }

    public static void MovedCamera()//просто метод, который будет вызвать событие
    {
        Moved();//вызываем событие для подписчиков
    }

    public static void SwitchCanvas(bool onMain)
    {
        print("вызвано событие через менеджер");
        SwitchCan(onMain);
    }

    public static void ChangeColor(Color color)
    {
        ColorChanger(color);
    }

    public static void WriteValue()
    {
        WritingValue();

    }


    //    public static float ToPersent(float min, float max, float value)
    //    {
    //        return Mathf.Abs((min - value) / (max - min));
    //    }

    //    public static float FromPersent(float min, float max, float persent)
    //    {
    //        return (max-min)*persent+min;
    //    }
    //}
}
