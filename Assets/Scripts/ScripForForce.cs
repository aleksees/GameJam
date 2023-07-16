using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;


public class ScripForForce : MonoBehaviour
{
    int forceCount;
    int powerCount;

    [SerializeField] Text ForceText;
    [SerializeField] Text CountText;

    // Start is called before the first frame update
    void Start()
    {
        forceCount = BuyForce.numForce;
        powerCount = BuyForce.numPower;
    }

    // Update is called once per frame
    void Update()
    {
        var count = powerCount - forceCount;

        ForceText.text = "МОЩЬ: " + (forceCount).ToString();
        CountText.text = "Количество зомби: " + (count).ToString();
    }
}
