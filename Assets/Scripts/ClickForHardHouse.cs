using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickForHardHouse : MonoBehaviour
{
    public Button button1;

    private void OnMouseDown()
    {
        var num = BuyForce.numForce;
        if (num >= 5)
        {
            button1.interactable = true;
        }
        else
        {
            button1.interactable = false;
            Debug.Log("Not enought power");
        }
    }
}
