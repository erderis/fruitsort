using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasSuccessControllerLv400 : MonoBehaviour
{
    GameObject background;
    GameObject awesomeBg;

    string[] textSuccess = {"Finish"};
    void Start()
    {
        background = GameObject.FindWithTag("background");
        awesomeBg = transform.GetChild(2).gameObject;

        string textAwesome = textSuccess[Random.Range(0, textSuccess.Length)];
        awesomeBg.transform.GetChild(0).GetComponent<Text>().text = textAwesome;

    }

}
