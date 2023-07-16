using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private SpriteRenderer rend2;
    public GameObject dice2;
    public GameObject destroy;
    public GameObject dice;
    //public Text text;
    private int check;
    public bool flag = true;
    public bool flag2 = true;
    public static int silaNum;

    [SerializeField] Text ForceText;
    [SerializeField] Text TwoForceText;

    public GameObject closedZomPicture1;
    public GameObject closedZomPicture2;
    public GameObject openZomPicture1;
    public GameObject openZomPicture2;

    public GameObject Force;
    public GameObject Force2;
    public GameObject Zom;
    public GameObject Noth;
    public GameObject Noth2;
    public GameObject houses;
    public GameObject panel;
    public GameObject zombies;
    public GameObject canvasText;

    public int forceNum2;


    public static int CountForce;
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend2 = dice2.GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");

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
            check = 0;
        }
    }

    private IEnumerator RollTheDice()
    {
        int randomDiceSide = 0;
        int randomDiceSide2 = 0;
        int randomNumber = 0;
        int finalSide = 0;
        int finalSide2 = 0;

        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(1, 5);
            randomDiceSide2 = Random.Range(3, 5);
            rend.sprite = diceSides[randomDiceSide];
            rend2.sprite = diceSides[randomDiceSide2];
            yield return new WaitForSeconds(0.08f);
        }

        finalSide = randomDiceSide + 1;
        finalSide2 = randomDiceSide2 + 1;
        var numForce = int.Parse(ForceText.text.Split(' ')[1]);

        if (dice.tag == "shop" )
        {
            if ((finalSide + finalSide2) <= 6)
            {
                Noth.SetActive(true);
                zombies.SetActive(false);
                panel.SetActive(true);
                houses.SetActive(false);
                canvasText.SetActive(false);
                Debug.Log("ничего");
            }
            else
            {
                randomNumber = Random.Range(0, 2);
                if (randomNumber == 0)
                {
                    ForceText.text = "МОЩЬ: " + (numForce+1).ToString();
                    
                    forceNum2 = int.Parse(TwoForceText.text.Split(' ')[1]);
                    forceNum2 += 1;
                    TwoForceText.text = "Мощь: " + (forceNum2).ToString();

                    silaNum += 1;

                    Force.SetActive(true);
                    zombies.SetActive(false);
                    panel.SetActive(true);
                    houses.SetActive(false);
                    canvasText.SetActive(false);
                }
                else
                {
                    Debug.Log("+1 зомби");
                    StartCoroutine(GetComponent<SpawnZomby>().SpawnCD());

                    forceNum2 = int.Parse(TwoForceText.text.Split(' ')[1]);
                    forceNum2 += 2;
                    TwoForceText.text = "Мощь: " + (forceNum2).ToString();

                    closedZomPicture1.SetActive(false);
                    closedZomPicture2.SetActive(false);
                    openZomPicture1.SetActive(true); 
                    openZomPicture2.SetActive(true);

                    Zom.SetActive(true);
                    panel.SetActive(true);
                    zombies.SetActive(false);
                    houses.SetActive(false);
                    canvasText.SetActive(false);
                }
            }
            check++;

        }
        else if (dice.tag == "bush")
        {
            if ((finalSide + finalSide2) <= 6)
            {
                Debug.Log("ничего");
                Noth2.SetActive(true);
                panel.SetActive(true);
                zombies.SetActive(false);
                houses.SetActive(false);
                canvasText.SetActive(false);
            }
            else
            {
                ForceText.text = "МОЩЬ: " + (numForce + 1).ToString();

                forceNum2 = int.Parse(TwoForceText.text.Split(' ')[1]);
                forceNum2 += 1;
                TwoForceText.text = "Мощь: " + (forceNum2++).ToString();

                silaNum += 1;

                Force2.SetActive(true);
                panel.SetActive(true);
                zombies.SetActive(false);
                houses.SetActive(false);
                canvasText.SetActive(false);
            }
            check++;
        }

    }
}