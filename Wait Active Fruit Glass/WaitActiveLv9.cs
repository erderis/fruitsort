﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitActiveLv9 : MonoBehaviour
{
    GameObject background;

    List<GameObject> glasses;
    List<GameObject> fruits;

    void Start()
    {
        background = GameObject.FindWithTag("background");

        glasses = new List<GameObject>();
        fruits = new List<GameObject>();
        glasses = background.GetComponent<InitGlassLv5>().glasses;
        fruits = background.GetComponent<InitFruitLv9>().fruits;

        foreach (GameObject glass in glasses)
        {
            glass.SetActive(false);
        }
        foreach (GameObject fruit in fruits)
        {
            fruit.SetActive(false);
        }
        Invoke("ShowFruitGlass", 0.2f);
    }

    void ShowFruitGlass()
    {
        foreach(GameObject glass in glasses)
        {
            glass.SetActive(true);
        }
        foreach(GameObject fruit in fruits)
        {
            fruit.SetActive(true);
        }
    }


}