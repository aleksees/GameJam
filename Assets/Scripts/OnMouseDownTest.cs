using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class OnMouseDownTest : MonoBehaviour
{
    [SerializeField] Text ForceText;

    public static int force;

    public MoveToMouseResult scr;

    private bool flag = true;

    void Start()
    {

    }
    private void OnMouseDown()
    {
        force = int.Parse(ForceText.text.Split(' ')[1]);
        scr = GetComponent<MoveToMouseResult>();
        scr.enabled = true;
        if (flag)
        {
            force++;
            ForceText.text = "лныэ: " + (force).ToString();
            flag = false;
        }

    }
}
