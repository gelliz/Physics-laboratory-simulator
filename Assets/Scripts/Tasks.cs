using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tasks : MonoBehaviour
{
    [SerializeField]
    Text taskText;
    Image myimage;

    [SerializeField]
    Button addButton;
    [SerializeField]
    Image addButtonImage;

    [SerializeField]
    Button tableButton;
    [SerializeField]
    Image tableButtonImage;
    [SerializeField]

    Button clearTableButton;
    [SerializeField]
    Image clearTableButtonImage;

    [SerializeField]
    GameObject inputArea;



    int numberOfTask = 0;

    void Start()
    {
        myimage = GetComponent<Image>();
        myimage.enabled = false;
        taskText.enabled = false;
        addButton.GetComponent<Image>().enabled = false;
        tableButton.GetComponent<Image>().enabled = false;
        clearTableButton.GetComponent<Image>().enabled = false;
        addButtonImage.enabled = false;
        tableButtonImage.enabled = false;
        clearTableButtonImage.enabled = false;
        inputArea.SetActive(false);

        taskText.text = ++numberOfTask + ". " + "Включите установку";
        EventManager.WhatTask(numberOfTask);
        EventManager.Switch += Task1;
    }

    void Task1(bool w)
    {

            EventManager.Switch -= Task1;
            taskText.text = ++numberOfTask + ". " + "Включите панель управления, нажав на правую крайнюю кнопку";
        
        EventManager.StartTxt += Task2;
            Open();
    }

    void Task2()
    {

        EventManager.StartTxt -= Task2;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления меди в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task3;
        Open();
    }

    void Task3()
    {

        EventManager.WritingValue -= Task3;
        taskText.text = ++numberOfTask + ". " + "Переключите металл";
        EventManager.SwitchM += Task4;
        Open();
    }

    void Task4(bool w)
    {

        EventManager.SwitchM -= Task4;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления вольфрама в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task5;
        Open();
    }

    void Task5()
    {

        EventManager.WritingValue -= Task5;
        taskText.text = ++numberOfTask + ". " + "Переключите металл";
        EventManager.SwitchM += Task6;
        Open();
    }

    void Task6(bool w)
    {

        EventManager.SwitchM -= Task6;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления меди в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task7;
        Open();
    }

    void Task7()
    {

        EventManager.WritingValue -= Task7;
        taskText.text = ++numberOfTask + ". " + "Переключите металл";
        EventManager.SwitchM += Task8;
        Open();
    }

    void Task8(bool w)
    {

        EventManager.SwitchM -= Task8;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления вольфрама в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task9;
        Open();
    }

    void Task9()
    {

        EventManager.WritingValue -= Task9;
        taskText.text = ++numberOfTask + ". " + "Переключите металл";
        EventManager.SwitchM += Task10;
        Open();
    }

    void Task10(bool w)
    {

        EventManager.SwitchM -= Task10;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления меди в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task11;
        Open();
    }

    void Task11()
    {

        EventManager.WritingValue -= Task11;
        taskText.text = ++numberOfTask + ". " + "Переключите металл";
        EventManager.SwitchM += Task12;
        Open();
    }

    void Task12(bool w)
    {

        EventManager.SwitchM -= Task12;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления вольфрама в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task13;
        Open();
    }

    void Task13()
    {

        EventManager.WritingValue -= Task13;
        taskText.text = ++numberOfTask + ". " + "Переключите металл";
        EventManager.SwitchM += Task14;
        Open();
    }

    void Task14(bool w)
    {

        EventManager.SwitchM -= Task14;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления меди в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task15;
        Open();
    }

    void Task15()
    {

        EventManager.WritingValue -= Task15;
        taskText.text = ++numberOfTask + ". " + "Переключите металл";
        EventManager.SwitchM += Task16;
        Open();
    }

    void Task16(bool w)
    {

        EventManager.SwitchM -= Task16;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления вольфрама в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task17;
        Open();
    }

    void Task17()
    {

        EventManager.WritingValue -= Task17;
        taskText.text = ++numberOfTask + ". " + "Переключите металл";
        EventManager.SwitchM += Task18;
        Open();
    }

    void Task18(bool w)
    {

        EventManager.SwitchM -= Task18;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления меди в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task19;
        Open();
    }

    void Task19()
    {

        EventManager.WritingValue -= Task19;
        taskText.text = ++numberOfTask + ". " + "Переключите металл";
        EventManager.SwitchM += Task20;
        Open();
    }

    void Task20(bool w)
    {

        EventManager.SwitchM -= Task20;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления вольфрама в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task21;
        Open();
    }

    void Task21()
    {

        EventManager.WritingValue -= Task21;
        taskText.text = ++numberOfTask + ". " + "Переключите металл";
        EventManager.SwitchM += Task22;
        Open();
    }

    void Task22(bool w)
    {

        EventManager.SwitchM -= Task22;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления меди в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task23;
        Open();
    }

    void Task23()
    {

        EventManager.WritingValue -= Task23;
        taskText.text = ++numberOfTask + ". " + "Переключите металл";
        EventManager.SwitchM += Task24;
        Open();
    }

    void Task24(bool w)
    {

        EventManager.SwitchM -= Task24;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления вольфрама в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task25;
        Open();
    }

    void Task25()
    {

        EventManager.WritingValue -= Task25;
        taskText.text = ++numberOfTask + ". " + "Переключите металл";
        EventManager.SwitchM += Task26;
        Open();
    }

    void Task26(bool w)
    {

        EventManager.SwitchM -= Task26;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления меди в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task27;
        Open();
    }

    void Task27()
    {

        EventManager.WritingValue -= Task27;
        taskText.text = ++numberOfTask + ". " + "Переключите металл";
        EventManager.SwitchM += Task28;
        Open();
    }

    void Task28(bool w)
    {

        EventManager.SwitchM -= Task28;
        taskText.text = ++numberOfTask + ". " + "Запишите значение сопротивления вольфрама в таблицу";
        EventManager.WhatTask(numberOfTask);
        EventManager.WritingValue += Task29;
        Open();
    }

    void Task29()
    {

        EventManager.WritingValue -= Task29;
        taskText.text = ++numberOfTask + ". " + "Выключите установку";
        EventManager.Switch += Task30;
        Open();
    }

    void Task30(bool w)
    {

        EventManager.Switch -= Task30;
        taskText.text = ++numberOfTask + ". " + "Откройте дверь";
        EventManager.MovingDoor += Task31;
        Open();
    }

    void Task31(bool w)
    {
        EventManager.MovingDoor -= Task31;
        taskText.text = ++numberOfTask + ". " + "Сделайте выводы";
    }


    public void Open()
    {
        myimage.enabled = true;
        taskText.enabled = true;
        addButton.GetComponent<Image>().enabled = true;
        tableButton.GetComponent<Image>().enabled = true;
        clearTableButton.GetComponent<Image>().enabled = true;
        addButtonImage.enabled = true;
        tableButtonImage.enabled = true;
        clearTableButtonImage.enabled = true;
        inputArea.SetActive(true);
    }

    public void Close()
    {
        myimage.enabled = false;
        taskText.enabled = false;
        addButton.GetComponent<Image>().enabled = false;
        tableButton.GetComponent<Image>().enabled = false;
        clearTableButton.GetComponent<Image>().enabled = false;
        addButtonImage.enabled = false;
        tableButtonImage.enabled = false;
        clearTableButtonImage.enabled = false;
        inputArea.SetActive(false);
    }
}
