using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1 : MonoBehaviour
{
    [SerializeField] Text ForceText;
    [SerializeField] Text ExpText;

    public static float force;
    public int exp;

    void Start()
    {
        force = 2;
        exp = 0;
    }

}
