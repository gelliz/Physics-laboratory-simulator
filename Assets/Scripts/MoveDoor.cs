using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveDoor : MonoBehaviour
{

    [SerializeField]
    GameObject moveAround;

    bool onPress = false;
    bool check = true;
    bool open = false;
    private void OnMouseEnter()
    {
        onPress = true;
    }

    private void OnMouseExit()
    {
        onPress = false;
    }

    private void OnMouseDown()
    {
        if (check)
        {
            if (Input.GetMouseButton(0) && onPress)
            {
                if (!open)
                {
                    open = !open;
                    EventManager.MovedDoor(true);
                    transform.RotateAround(moveAround.transform.position, new Vector3(0, -1, 0), 25f);
                }
                else
                {
                    open = !open;
                    EventManager.MovedDoor(true);
                    transform.RotateAround(moveAround.transform.position, new Vector3(0, 1, 0), 25f);
                }
            }
            else
            {
                EventManager.MovedDoor(false);
            }
        }

    }

}