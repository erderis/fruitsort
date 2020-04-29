using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasSaveMeControllerLv3 : MonoBehaviour
{

    GameObject timer;
    Button saveMe;
    void Start()
    {
        timer = GameObject.FindWithTag("Timer");

        saveMe = transform.GetChild(1).GetChild(1).GetComponent<Button>();

        saveMe.onClick.AddListener(OnClickSaveMe);
    }

    void OnClickSaveMe()
    {
        timer.GetComponent<TimerLv3>().ContinueGame();
    }

}
