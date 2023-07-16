using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SpawnZomby : MonoBehaviour
{
    public Transform spawnPos;
    public Transform spawnPos2;
    public GameObject newZom;
    GameObject newZomSapwn;
    public Transform parent;

    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }

    public IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(0.01f);
        newZomSapwn = Instantiate(newZom, spawnPos.position, Quaternion.identity);
        newZomSapwn.transform.SetParent(parent);

    }
}
