using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasSuccessController : MonoBehaviour
{
    GameObject background;
    GameObject awesomeBg;
    Button next;

    string[] textSuccess = {"Awesome", "Great", "Cool", "Perfect", "Bravo"};
    void Start()
    {
        background = GameObject.FindWithTag("background");
        awesomeBg = transform.GetChild(2).gameObject;
        next = transform.GetChild(3).GetComponent<Button>();

        string textAwesome = textSuccess[Random.Range(0, textSuccess.Length)];
        awesomeBg.transform.GetChild(0).GetComponent<Text>().text = textAwesome;

        next.onClick.AddListener(nextOnClick);

    }

    void nextOnClick()
    {
        background.GetComponent<NavigationController>().NextLevel();
    }
}
