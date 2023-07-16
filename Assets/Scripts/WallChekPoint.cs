using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WallChekPoint : MonoBehaviour
{
    [SerializeField] Text ForceText;
    public static int force;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        force = int.Parse(ForceText.text.Split(' ')[1]);
        if (force >= 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
