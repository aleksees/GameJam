using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForZ2 : MonoBehaviour
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
            GameObject pl = GameObject.FindWithTag("Zomby2");
            MoveToMouseResult scr = pl.GetComponent<MoveToMouseResult>();
            scr.enabled = true;
        }
        else
        {
            GameObject pl = GameObject.FindWithTag("Zomby2");
            MoveToMouseResult scr = pl.GetComponent<MoveToMouseResult>();
            scr.enabled = false;
        }
    }
}
