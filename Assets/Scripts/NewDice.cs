using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewDice : MonoBehaviour
{
    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private SpriteRenderer rend2;
    public GameObject dice2;
    public GameObject destroy;
    public GameObject dice;
    public GameObject zom1;
    public GameObject panel;
    public GameObject zom2;
    public GameObject dicePres;
    public GameObject dicePres2;
    private int check;
    private int forceNum2;
    private int silaNum;

    [SerializeField] Text ForceHouseText;
    [SerializeField] Text CountText;
    [SerializeField] Text ForceText;
    [SerializeField] Text silaText;
    [SerializeField] Text TwoForceText;
    [SerializeField] Text ExpText;
    [SerializeField] Text TwoExpText;
    [SerializeField] Text BuyZom1;
    [SerializeField] Text BuyZom2;
    [SerializeField] Text BuyForceButton;

    int numForce;
    int numPower;
    int numNewForce;
    int numExp;

    private void Start()
    {
        numNewForce = int.Parse(ForceText.text.Split(' ')[1]); 

        numForce = numNewForce; //мощь
        numPower = BuyForce.numPower; //сила
        rend = GetComponent<SpriteRenderer>();
        rend2 = dice2.GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        ForceHouseText.text = "Мощь: " + (numForce).ToString();
        Debug.Log(Dice.silaNum);
        CountText.text = "Количество зомби: " + (numForce - numPower - Dice.silaNum).ToString();

        numExp = int.Parse(ExpText.text.Split(' ')[1]);
    }

    private void OnMouseDown()
    {
        if (check == 0)
        {
            StartCoroutine("RollTheDice");
        }
        else
        {
            Destroy(destroy);
            Destroy(panel);
            check = 0;
        }
    }

    private IEnumerator RollTheDice()
    {
        int randomDiceSide = 0;
        int randomDiceSide2 = 0;
        int finalSide = 0;
        int finalSide2 = 0;


        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 5);
            randomDiceSide2 = Random.Range(1, 5);
            rend.sprite = diceSides[randomDiceSide];
            rend2.sprite = diceSides[randomDiceSide2];
            yield return new WaitForSeconds(0.08f);
        }

        finalSide = randomDiceSide + 1;
        finalSide2 = randomDiceSide2 + 1;

        if (dice.tag == "house")
        {
            if ((finalSide + finalSide2) <= 6)
            {
                Debug.Log("-2 зомби");
                ForceHouseText.text = "Мощь: " + (numForce - 2).ToString();
                CountText.text = "Количество зомби: " + ((numForce - numPower - Dice.silaNum) - 2).ToString();
                ForceText.text = "МОЩЬ: " + (numNewForce-2).ToString();
                forceNum2 = int.Parse(TwoForceText.text.Split(' ')[1]);
                forceNum2 -= 2;
                TwoForceText.text = "Мощь: " + (forceNum2).ToString();

                ExpText.text = "ОПЫТ: " + (numExp + 4).ToString();
                TwoExpText.text = "Опыт: " + (numExp + 4).ToString();
                BuyZom1.text = (numExp + 4).ToString() + "/1";
                BuyZom2.text = (numExp + 4).ToString() + "/1";
                BuyForceButton.text = "Увеличить силу отряда " + (numExp + 4).ToString() + "/" + BuyForce.num;

                zom1.SetActive(false); zom2.SetActive(false);
                if (((numForce - numPower) - 2) == 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                else
                {
                    panel.SetActive(false);
                    dicePres2.SetActive(true);
                }
            }
            else
            {
                Debug.Log("+2 cила");
                ForceHouseText.text = "Мощь: " + (numForce + 2).ToString();
                ForceText.text = "МОЩЬ: " + (numNewForce + 2).ToString();

                silaNum = int.Parse(silaText.text.Split(' ')[1]);
                silaNum += 2;
                silaText.text = "Сила: " + (silaNum).ToString();

                ExpText.text = "ОПЫТ: " + (numExp + 4).ToString();
                TwoExpText.text = "Опыт: " + (numExp + 4).ToString();
                BuyZom1.text = (numExp + 4).ToString() + "/1";
                BuyZom2.text = (numExp + 4).ToString() + "/1";
                BuyForceButton.text = "Увеличить силу отряда " + (numExp + 4).ToString() + "/" + BuyForce.num;

                forceNum2 = int.Parse(TwoForceText.text.Split(' ')[1]);
                forceNum2 += 2;
                TwoForceText.text = "Мощь: " + (forceNum2).ToString();
                panel.SetActive(false);
                dicePres.SetActive(true);
            }
            check++;
        }
    }
}
