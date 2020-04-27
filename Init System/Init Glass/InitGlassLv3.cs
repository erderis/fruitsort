using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGlassLv3 : MonoBehaviour
{
    public GameObject glass;

    void Start()
    {
        Instantiate(glass, new Vector3(-7.41f, -6.11f, -1f), Quaternion.identity);
        Instantiate(glass, new Vector3(-3.77f, -6.11f, -1f), Quaternion.identity);
        Instantiate(glass, new Vector3(0, -6.11f, -1f), Quaternion.identity);
        Instantiate(glass, new Vector3(3.72f, -6.11f, -1f), Quaternion.identity);
        Instantiate(glass, new Vector3(7.4f, -6.11f, -1f), Quaternion.identity);
    }
  
}
