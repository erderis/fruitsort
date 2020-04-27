using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitActiveLv119 : MonoBehaviour
{
    GameObject background;

    List<GameObject> glasses;
    List<GameObject> fruits;

    void Start()
    {
        background = GameObject.FindWithTag("background");

        glasses = new List<GameObject>();
        fruits = new List<GameObject>();
        glasses = background.GetComponent<InitGlassLv101>().glasses;
        fruits = background.GetComponent<InitFruitLv119>().fruits;

        foreach (GameObject glass in glasses)
        {
            glass.SetActive(false);
        }
        foreach (GameObject fruit in fruits)
        {
            fruit.SetActive(false);
        }
        Invoke("ShowFruitGlass", 0.5f);
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
