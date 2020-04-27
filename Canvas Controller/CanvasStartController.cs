﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasStartController : MonoBehaviour
{
    GameObject background;
    GameObject iapManager;
    GameObject imageStage;
    Button buttonAds;
    Button buttonTheme;
    Button textStart;
    void Start()
    {
        background = GameObject.FindWithTag("background");
        iapManager = GameObject.FindWithTag("IAP Manager");
        imageStage = transform.GetChild(1).gameObject;
        buttonAds = transform.GetChild(2).GetComponent<Button>();
        buttonTheme = transform.GetChild(3).GetComponent<Button>();
        textStart = transform.GetChild(4).GetComponent<Button>();


        string currentScene = SceneManager.GetActiveScene().name;
        char[] splitScene = currentScene.ToCharArray();

        if (currentScene == "Level2")
        {
            PlayerPrefs.SetString("isLevel2", "true");
            PlayerPrefs.SetString("isLevel10", "false");
            PlayerPrefs.SetString("isLevel100", "false");

        }
        if (currentScene == "Level10")
        {
            PlayerPrefs.SetString("isLevel10", "true");
            PlayerPrefs.SetString("isLevel2", "false");
            PlayerPrefs.SetString("isLevel100", "false");
        }
        if (currentScene == "Level100")
        {
            PlayerPrefs.SetString("isLevel100", "true");
            PlayerPrefs.SetString("isLevel10", "false");
            PlayerPrefs.SetString("isLevel2", "false");

        }
        string isLevel2 = PlayerPrefs.GetString("isLevel2", "false");
        string isLevel10 = PlayerPrefs.GetString("isLevel10", "false");
        string isLevel100 = PlayerPrefs.GetString("isLevel100", "false");

        int numberNext = int.Parse(splitScene[splitScene.Length - 1].ToString());

        if (isLevel10 == "true")
        {
            int num1 = int.Parse(splitScene[splitScene.Length - 2].ToString());
            int num2 = int.Parse(splitScene[splitScene.Length - 1].ToString());
            numberNext = int.Parse(num1.ToString()+num2.ToString());

        }
        else if(isLevel100 == "true")
        {
            int num1 = int.Parse(splitScene[splitScene.Length - 3].ToString());
            int num2 = int.Parse(splitScene[splitScene.Length - 2].ToString());
            int num3 = int.Parse(splitScene[splitScene.Length - 1].ToString());
            numberNext = int.Parse(num1.ToString() + num2.ToString()+num3.ToString());

        }
        else
        {
            numberNext = int.Parse(splitScene[splitScene.Length - 1].ToString());
        }


        imageStage.transform.GetChild(0).GetComponent<Text>().text = numberNext.ToString();
        imageStage.transform.GetChild(1).GetComponent<Text>().text = (numberNext + 1).ToString();

        buttonAds.onClick.AddListener(buttonAdsOnClick);
        buttonTheme.onClick.AddListener(buttonThemeOnClick);
        textStart.onClick.AddListener(buttonStartOnClick);

    }

    void buttonAdsOnClick()
    {
        iapManager.GetComponent<IAPManager>().BuyRemoveAds();
    }

    void buttonThemeOnClick()
    {
        background.GetComponent<NavigationController>().LoadTheme();
    }

    void buttonStartOnClick()
    {
        background.GetComponent<NavigationController>().TextStart();
    }
}
