using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProgressBar : MonoBehaviour
{
    [SerializeField] Text ForceText;
    [SerializeField] Text progressText;
    [SerializeField] Slider slider;
    int num;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        num = int.Parse(ForceText.text.Split(' ')[1]);
        slider.value = num;
        progressText.text = (slider.value).ToString() + "/10";
    }
}
