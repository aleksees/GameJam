using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseDownForNewZomby : MonoBehaviour
{
    [SerializeField] Text ExpText;
    [SerializeField] Text TwoExpText;
    [SerializeField] Text BuyZom1;
    [SerializeField] Text BuyZom2;
    [SerializeField] Text BuyForceButton;
    [SerializeField] Text CountText;
    [SerializeField] Text TwoForceText;
    private int forceNum2;


    public Button button1;
    public Button button2;
    void Start()
    {
    }
    private void OnMouseDown()
    {
        Debug.Log("TRue");
        var numExp = int.Parse(ExpText.text.Split(' ')[1]);
        var numFor = int.Parse(TwoForceText.text.Split(' ')[1]);
        if (numExp < 2)
        {
            button1.interactable = false;
            button2.interactable = false;
        }
        else
        {
            button1.interactable = true;
            button2.interactable = true;
            numExp = numExp - 1;
            ExpText.text = "ОПЫТ: " + (numExp).ToString();
            TwoExpText.text = "Опыт: " + (numExp).ToString();

            forceNum2 = int.Parse(TwoForceText.text.Split(' ')[1]);
            forceNum2 += 1;
            TwoForceText.text = "Мощь: " + (forceNum2).ToString();

            BuyZom1.text = (numExp).ToString() + "/1";
            BuyZom2.text = (numExp).ToString() + "/1";
            BuyForceButton.text = "Увеличить силу отряда " + (numExp).ToString() + "/" + BuyForce.num;

            StartCoroutine(GetComponent<SpawnZomby>().SpawnCD());

        }
    }
}
