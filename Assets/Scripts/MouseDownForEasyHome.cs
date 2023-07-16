using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseDownForEasyHome : MonoBehaviour
{
    [SerializeField] Text ForceText;
    [SerializeField] Text ExpText;
    [SerializeField] Text TwoExpText;
    [SerializeField] Text BuyZom1;
    [SerializeField] Text BuyZom2;
    [SerializeField] Text BuyForceButton;

    public GameObject EasyHome1;
    public GameObject EasyHome2;
    public GameObject EasyHomeText;
    private bool flag = true;

    private void OnMouseDown()
    {
        Debug.Log("mdfeh");
        var numForce = int.Parse(ForceText.text.Split(' ')[1]);
        var exp = 0;
        if (numForce >= 2 && flag == true)
        {
            exp++;
            ExpText.text = "ОПЫТ: " + (exp).ToString();
            TwoExpText.text = "Опыт: " + (exp).ToString();

            BuyZom1.text = (exp).ToString() + "/1";
            BuyZom2.text = (exp).ToString() + "/1";
            BuyForceButton.text = "Увеличить силу отряда " + (exp).ToString() + "/" + BuyForce.num;

            EasyHome1.SetActive(false);
            EasyHomeText.SetActive(false);
            EasyHome2.SetActive(true);

            flag = false;
        }
    }
}
