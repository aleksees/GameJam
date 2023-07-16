using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testssss : MonoBehaviour
{
    [SerializeField] Text ForceText;
    //[SerializeField] Text ExpText;

    [SerializeField] Text ChangeForceText;
    //[SerializeField] Text ChangeExpText;

    void ChageNext()
    {
        var numForce = int.Parse(ForceText.text.Split(' ')[1]);
        //var numExp = int.Parse(ExpText.text.Split(' ')[1]);

        ChangeForceText.text = "лныэ: " + (numForce).ToString();
    }
}
