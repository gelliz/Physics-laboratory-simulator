using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableValues : MonoBehaviour
{
    #region rCu
    [SerializeField]
    Text rCu1;

    [SerializeField]
    Text rCu2;

    [SerializeField]
    Text rCu3;

    [SerializeField]
    Text rCu4;

    [SerializeField]
    Text rCu5;

    [SerializeField]
    Text rCu6;

    [SerializeField]
    Text rCu7;
    #endregion
    #region rW
    [SerializeField]
    Text rW1;

    [SerializeField]
    Text rW2;

    [SerializeField]
    Text rW3;

    [SerializeField]
    Text rW4;

    [SerializeField]
    Text rW5;

    [SerializeField]
    Text rW6;

    [SerializeField]
    Text rW7;
    #endregion
    #region q
    [SerializeField]
    Text q1;

    [SerializeField]
    Text q2;

    [SerializeField]
    Text q3;

    [SerializeField]
    Text q4;

    [SerializeField]
    Text q5;

    [SerializeField]
    Text q6;

    [SerializeField]
    Text q7;
    #endregion
    #region az
    [SerializeField]
    Text az1;

    [SerializeField]
    Text az2;

    [SerializeField]
    Text az3;

    [SerializeField]
    Text az4;

    [SerializeField]
    Text az5;

    [SerializeField]
    Text az6;

    [SerializeField]
    Text az7;
    #endregion
    #region azq
    [SerializeField]
    Text azq1;

    [SerializeField]
    Text azq2;

    [SerializeField]
    Text azq3;

    [SerializeField]
    Text azq4;

    [SerializeField]
    Text azq5;

    [SerializeField]
    Text azq6;

    [SerializeField]
    Text azq7;
    #endregion

    [SerializeField]
    Text Rtext;

    [SerializeField]
    InputField textInput;
   

    double sl = Math.Pow(0.15, -9.0);

    double back;

    //const float y = 0.0283f;//мм
    private void Start()
    {
        EventManager.TaskNumber += num;
    }

    int tasknum;
    public void num(int ts)
    {
        tasknum = ts;
    }


    public void WriteValue()
    {
       
        string valueText = textInput.text;
        //int newValue = 0;

        if (rCu1.text == "_")
        {
            if (tasknum == 3)
            {
                rCu1.text = valueText;
                EventManager.WriteValue();
                back = Convert.ToDouble(valueText);
            }

        }
        else if (rW1.text == "_")
        {
            if (tasknum == 5)
            {
                rW1.text = valueText;
                q1.text = (1 / (back * sl)).ToString();
                azq1.text = (Convert.ToDouble(az1) / (1 / (back * sl))).ToString();
                EventManager.WriteValue();
            }

        }

        else if (rCu2.text == "_")
        {
            if (tasknum == 7)
            {
                rCu2.text = valueText;
                EventManager.WriteValue();
                back = Convert.ToDouble(valueText);
            }

        }
        else if (rW2.text == "_")
        {
            if (tasknum == 9)
            {
                rW2.text = valueText;
                q2.text = (1 / (back * sl)).ToString();
                azq2.text = (Convert.ToDouble(az2) / (1 / (back * sl))).ToString();
                EventManager.WriteValue();
            }

        }

        else if (rCu3.text == "_")
        {
            if (tasknum == 11)
            {
                rCu3.text = valueText;
                EventManager.WriteValue();
                back = Convert.ToDouble(valueText);
            }

        }
        else if (rW3.text == "_")
        {
            if (tasknum == 13)
            {
                rW3.text = valueText;
                q3.text = (1 / (back * sl)).ToString();
                azq3.text = (Convert.ToDouble(az3) / (1 / (back * sl))).ToString();
                EventManager.WriteValue();
            }

        }

        else if (rCu4.text == "_")
        {
            if (tasknum == 15)
            {
                rCu4.text = valueText;
                EventManager.WriteValue();
                back = Convert.ToDouble(valueText);
            }

        }
        else if (rW4.text == "_")
        {
            if (tasknum == 17)
            {
                rW4.text = valueText;
                q4.text = (1 / (back * sl)).ToString();
                azq4.text = (Convert.ToDouble(az4) / (1 / (back * sl))).ToString();
                EventManager.WriteValue();
            }

        }

        else if (rCu5.text == "_")
        {
            if (tasknum == 19)
            {
                rCu5.text = valueText;
                EventManager.WriteValue();
                back = Convert.ToDouble(valueText);
            }

        }
        else if (rW5.text == "_")
        {
            if (tasknum == 21)
            {
                rW5.text = valueText;
                q5.text = (1 / (back * sl)).ToString();
                azq5.text = (Convert.ToDouble(az5) / (1 / (back * sl))).ToString();
                EventManager.WriteValue();
            }

        }

        else if (rCu6.text == "_")
        {
            if (tasknum == 23)
            {
                rCu6.text = valueText;
                EventManager.WriteValue();
                back = Convert.ToDouble(valueText);
            }

        }
        else if (rW6.text == "_")
        {
            if (tasknum == 25)
            {
                rW6.text = valueText;
                q6.text = (1 / (back * sl)).ToString();
                azq6.text = (Convert.ToDouble(az6) / (1 / (back * sl))).ToString();
                EventManager.WriteValue();
            }

        }

        else if (rCu7.text == "_")
        {
            if (tasknum == 27)
            {
                rCu7.text = valueText;
                EventManager.WriteValue();
                back = Convert.ToDouble(valueText);
            }

        }
        else if (rW7.text == "_")
        {
            if (tasknum == 29)
            {
                rW7.text = valueText;
                q7.text = (1 / (back * sl)).ToString();
                azq7.text = (Convert.ToDouble(az7) / (1 / (back * sl))).ToString();
                EventManager.WriteValue();
            }

        }


        textInput.text="";
    }

    public void Clean()
    {
        rCu1.text = "_";
        rCu2.text = "_";
        rCu3.text = "_";
        rCu4.text = "_";
        rCu5.text = "_";
        rCu6.text = "_";
        rCu7.text = "_";
        rW1.text = "_";
        rW2.text = "_";
        rW3.text = "_";
        rW4.text = "_";
        rW5.text = "_";
        rW6.text = "_";
        rW7.text = "_";
    }

}
