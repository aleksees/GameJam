using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MouseDownForSuperHard : MonoBehaviour
{
    [SerializeField] Text ForceText;
    [SerializeField] Text ExpText;
    [SerializeField] Text TwoExpText;
    [SerializeField] Text BuyZom1;
    [SerializeField] Text BuyZom2;
    [SerializeField] Text BuyForceButton;
    public GameObject canvasText;

    public GameObject gameLocation;
    public GameObject SuperHard;
    public GameObject superHardHomeText;

    //private bool flag = true;

    private void OnMouseDown()
    {
        var numForce = int.Parse(ForceText.text.Split(' ')[1]);
        var exp = int.Parse(ExpText.text.Split(' ')[1]);
        if (numForce >= 6/* && flag == true*/)
        {
            ////exp = exp + 4;
            ////ExpText.text = "Опыт: " + (exp).ToString();
            ////TwoExpText.text = "Опыт: " + (exp).ToString();

            ////BuyZom1.text = (exp).ToString() + "/2";
            ////BuyZom2.text = (exp).ToString() + "/5";
            ////BuyForceButton.text = "Купить силу " + (exp).ToString() + "/1";

            ////flag = false;

            //var num = BuyForce.numForce;
            //if (num >= 4)
            //{
                gameLocation.SetActive(false);
                SuperHard.SetActive(true);
            canvasText.SetActive(false);
            superHardHomeText.SetActive(false);
            //}
            //else
            //{
            //    Debug.Log("Not enought power");
            //}
        }
    }
}
