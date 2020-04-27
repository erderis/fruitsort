﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class TimerLv101 : MonoBehaviour, IUnityAdsListener
{
    GameObject background;


    public float timeLeft;
    float saveTimeLeft;
    float timeLeftSaveMe = 0;
    Text countDown;
    bool isReady = false;



    string gameId = "3524520";
    string myPlacementId = "Continue_Game";
    bool testMode = true;

    bool onetime = false;




    // Start is called before the first frame update
    void Start()
    {
        background = GameObject.FindWithTag("background");

        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, testMode);

        saveTimeLeft = timeLeft;

        countDown = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string isShowingAdsUndo = PlayerPrefs.GetString("isShowingAdsUndo", "false");
        if (isShowingAdsUndo == "false")
        {
            timeLeft -= Time.deltaTime;
        }
        string[] countdownList = timeLeft.ToString().Split('.');
        countDown.text = countdownList[0];


        int tagOrange = PlayerPrefs.GetInt("orange");
        int tagCherry = PlayerPrefs.GetInt("cherry");
        int tagBanana = PlayerPrefs.GetInt("banana");
        int tagApple = PlayerPrefs.GetInt("apple");
        int tagMelon = PlayerPrefs.GetInt("melon");
        int tagStrawberry = PlayerPrefs.GetInt("strawberry");
        int tagEggplant = PlayerPrefs.GetInt("eggplant");
        int tagPumpkin = PlayerPrefs.GetInt("pumpkin");
        int tagGrape = PlayerPrefs.GetInt("grape");
        int tagBlackBerry = PlayerPrefs.GetInt("blackberry");
        int tagBlueBerry = PlayerPrefs.GetInt("blueberry");
        int tagManggoes = PlayerPrefs.GetInt("manggoes");


        if (tagOrange == 1 && tagCherry == 1 && tagBanana == 1 && tagApple == 1 && tagMelon == 1 && tagPumpkin == 1 && tagGrape == 1 && tagBlackBerry == 1 && tagBlueBerry == 1 && tagManggoes == 1)
        {
            countDown.text = "";
            timeLeft = 0;

        }
        if (timeLeft < 0)
        {
            countDown.text = "";
            if (!onetime)
            {
                ShowCanvasSaveMe();
                onetime = true;
            }
            timeLeftSaveMe += Time.deltaTime;
            if (timeLeftSaveMe >= 5)
            {
                timeLeft = 0;
                HideCanvasSaveMe();
                GameOver();
            }
        }
        if (timeLeft < 10 && timeLeft > 0)
        {
            countDown.color = Color.red;
        }


    }
    void ShowCanvasSaveMe()
    {
        background.GetComponent<NavigationController>().ShowCanvasSaveMe();

    }
    void HideCanvasSaveMe()
    {
        background.GetComponent<NavigationController>().HideCanvasSaveMe();

    }
    void GameOver()
    {
        background.GetComponent<NavigationController>().GameOver();

    }

    public void ContinueGame()
    {

        if (isReady)
        {
            HideCanvasSaveMe();
            timeLeft = 0;
            Advertisement.Show(myPlacementId);
        }

    }



    public void OnUnityAdsDidError(string message)
    {

    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished && placementId == myPlacementId)
        {
            PlayerPrefs.SetString("isShowingAdsUndo", "false");
            timeLeft = saveTimeLeft;
            timeLeftSaveMe = 0;
            onetime = false;
            countDown.color = Color.white;
        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsDidStart(string placementId)
    {

    }

    public void OnUnityAdsReady(string placementId)
    {
        if (placementId == myPlacementId)
        {
            isReady = true;
        }
    }

}
