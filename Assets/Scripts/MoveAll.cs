using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveAll : MonoBehaviour
{
    bool isClicked; //вводим булевую переменную
    public void TaskOnClick()
    {
        isClicked = true;
    }
    void Update()
    {
        if (isClicked)
        {
            GameObject pl = GameObject.FindWithTag("Player");
            MoveToMouseResult scr = pl.GetComponent<MoveToMouseResult>();
            scr.enabled = true;
        }
        else
        {
            GameObject pl = GameObject.FindWithTag("Player");
            MoveToMouseResult scr = pl.GetComponent<MoveToMouseResult>();
            scr.enabled = false;
        }
    }
}
