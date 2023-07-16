using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseDownForMedium : MonoBehaviour
{
    [SerializeField] Text ForceText;
    [SerializeField] Text ExpText;
    [SerializeField] Text TwoExpText;
    [SerializeField] Text BuyZom1;
    [SerializeField] Text BuyZom2;
    [SerializeField] Text BuyForceButton;
    private bool flag = true;

    public GameObject MediumHome1;
    public GameObject MediumHome2;
    public GameObject MediumHomeText;

private void OnMouseDown()
    {
        var numForce = int.Parse(ForceText.text.Split(' ')[1]);
        var exp = int.Parse(ExpText.text.Split(' ')[1]);
        if (numForce >= 3 && flag == true)
        {
            exp = exp + 2;
            ExpText.text = "ОПЫТ: " + (exp).ToString();
            TwoExpText.text = "Опыт: " + (exp).ToString();

            BuyZom1.text = (exp).ToString() + "/1";
            BuyZom2.text = (exp).ToString() + "/1";
            BuyForceButton.text = "Увеличить силу отряда " + (exp).ToString() + "/" + BuyForce.num;

            MediumHome1.SetActive(false);
            MediumHomeText.SetActive(false);
            MediumHome2.SetActive(true);

            flag = false;
        }
    }
}
