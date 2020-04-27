using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGlassLv10 : MonoBehaviour
{
    public GameObject glass;

    public GameObject glass1;
    public GameObject glass2;
    public GameObject glass3;
    public GameObject glass4;
    public GameObject glass5;
    public GameObject glass6;
    public GameObject glass7;
    public GameObject glass8;
    public GameObject glass9;

    public List<GameObject> glasses;

    void Start()
    {
        glass1 = Instantiate(glass, new Vector3(-7f, 6f, -1f), Quaternion.identity);
        glass2 = Instantiate(glass, new Vector3(-3.5f, 6f, -1f), Quaternion.identity);
        glass3 = Instantiate(glass, new Vector3(0, 6f, -1f), Quaternion.identity);
        glass4 = Instantiate(glass, new Vector3(3.5f, 6f, -1f), Quaternion.identity);
        glass5 = Instantiate(glass, new Vector3(7f, 6f, -1f), Quaternion.identity);
        glass6 = Instantiate(glass, new Vector3(-6f, -9.5f, -1f), Quaternion.identity);
        glass6 = Instantiate(glass, new Vector3(-2f, -9.5f, -1f), Quaternion.identity);
        glass6 = Instantiate(glass, new Vector3(2f, -9.5f, -1f), Quaternion.identity);
        glass6 = Instantiate(glass, new Vector3(6f, -9.5f, -1f), Quaternion.identity);

        glasses = new List<GameObject>();

        glasses.Add(glass1);
        glasses.Add(glass2);
        glasses.Add(glass3);
        glasses.Add(glass4);
        glasses.Add(glass5);

    }
  
}
