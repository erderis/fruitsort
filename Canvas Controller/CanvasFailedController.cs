using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasFailedController : MonoBehaviour
{
    GameObject background;
    Button repeat;
    void Start()
    {
        background = GameObject.FindWithTag("background");
        repeat = transform.GetChild(2).GetComponent<Button>();

        repeat.onClick.AddListener(onClickRepeat);
    }

    void onClickRepeat()
    {
        background.GetComponent<NavigationController>().RepeatfromStart();
    }

}
