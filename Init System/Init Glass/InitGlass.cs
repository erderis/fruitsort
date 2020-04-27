using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGlass : MonoBehaviour
{
    public GameObject glass;

    void Start()
    {
        Instantiate(glass, new Vector3(-6.15f, -6.11f, -1f), Quaternion.identity);
        Instantiate(glass, new Vector3(-0.11f, -6.11f, -1f), Quaternion.identity);
        Instantiate(glass, new Vector3(5.98f, -6.11f, -1f), Quaternion.identity);
    }
  
}
