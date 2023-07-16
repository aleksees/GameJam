using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyForce : MonoBehaviour
{
    [SerializeField] Text ExpText;
    [SerializeField] Text TwoExpText;
    [SerializeField] Text ForceText;
    [SerializeField] Text TwoForceText;
    [SerializeField] Text PowerText;
    [SerializeField] Text BuyZom1;
    [SerializeField] Text BuyZom2;
    [SerializeField] Text BuyForceButton;
    public static int numExp;
    public static int numForce;
    public static int numPower;
    public static int count;
    private int forceNum2;
    public static int num = 1;

    void Start()
    {
        var countForce = Dice.CountForce;
        numPower += countForce;
        PowerText.text = "Сила: " + (numPower).ToString();
    }

    public void BuyForceInStore()
    {

        numExp = int.Parse(ExpText.text.Split(' ')[1]);
        numForce = int.Parse(ForceText.text.Split(' ')[1]);

        if (numExp >= num)
        {
            numForce += 1;
            numPower += 1;
            numExp = numExp - num;

            ExpText.text = "ОПЫТ: " + (numExp).ToString();
            TwoExpText.text = "Опыт: " + (numExp).ToString();
            ForceText.text = "МОЩЬ: " + (numForce).ToString();

            forceNum2 = int.Parse(TwoForceText.text.Split(' ')[1]);
            forceNum2 += 1;
            TwoForceText.text = "Мощь: " + (forceNum2).ToString();

            PowerText.text = "Сила: " + (numPower).ToString();

            BuyZom1.text = (numExp).ToString() + "/1";
            BuyZom2.text = (numExp).ToString() + "/1";

            if (num < 3)
            {
                num += 1;
            }
            BuyForceButton.text = "Увеличить силу отряда " + (numExp).ToString() + "/" + num;
        }
        else
        {
            Debug.Log("Not enought exp");
        }

    }
}
