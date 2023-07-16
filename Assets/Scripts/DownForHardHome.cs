using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownForHardHome : MonoBehaviour
{
    [SerializeField] Text ForceText;
    [SerializeField] Text ExpText;
    [SerializeField] Text TwoExpText;
    [SerializeField] Text BuyZom1;
    [SerializeField] Text BuyZom2;
    [SerializeField] Text BuyForceButton;
    private bool flag = true;

    public GameObject HardHome1;
    public GameObject HardHome2;
    public GameObject HardHomeText;

    private void OnMouseDown()
    {
        var numForce = int.Parse(ForceText.text.Split(' ')[1]);
        var exp = int.Parse(ExpText.text.Split(' ')[1]);
        if (numForce >= 4 && flag == true)
        {
            exp = exp + 3;
            ExpText.text = "ОПЫТ: " + (exp).ToString();
            TwoExpText.text = "Опыт: " + (exp).ToString();

            BuyZom1.text = (exp).ToString() + "/1";
            BuyZom2.text = (exp).ToString() + "/1";
            BuyForceButton.text = "Увеличить силу отряда " + (exp).ToString() + "/" + BuyForce.num;

            HardHome1.SetActive(false);
            HardHomeText.SetActive(false);
            HardHome2.SetActive(true);

            flag = false;
        }
    }
}
