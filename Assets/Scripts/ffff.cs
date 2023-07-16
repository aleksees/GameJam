using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ffff : MonoBehaviour
{
    [SerializeField] Text ForceText;
    [SerializeField] Text ResText;
    void Update()
    {
       var numForce = int.Parse(ForceText.text.Split(' ')[1]);
        ResText.text = (numForce).ToString() + "/10";
    }
}
