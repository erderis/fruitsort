using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
public class BgOnClick1 : MonoBehaviour, IUnityAdsListener
{
    GameObject music;

    string gameId = "3524520";
    string myPlacementId = "bg_Theme1";
    bool testMode = false;

    bool isReady = false;

    void Start()
    {
        music = GameObject.FindWithTag("music");
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, testMode);

    }

    void Update()
    {

    }

    public void OnClicked()
    {
        music.GetComponent<MusicClass>().ButtonSound();

        string isShowAds = PlayerPrefs.GetString("AdsBg1", "false");

        if (isShowAds == "false")
        {
            if (isReady)
            {
                Advertisement.Show(myPlacementId);
            }
        }
        else
        {
            SetBg();
        }

    }

    void SetBg()
    {

        string nameTag = PlayerPrefs.GetString("bgTag", "default");

        GameObject currentGO = GameObject.FindWithTag(nameTag);

        currentGO.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Use";
        GameObject check = currentGO.transform.GetChild(1).gameObject;
        check.SetActive(false);

        transform.GetChild(0).gameObject.GetComponent<Text>().text = "Used    ";
        GameObject newCheck = transform.GetChild(1).gameObject;
        newCheck.SetActive(true);

        PlayerPrefs.SetString("bgTag", transform.tag);

        GameObject ads = transform.GetChild(2).gameObject;
        ads.SetActive(false);

        PlayerPrefs.SetString("AdsBg1", "true");


    }



    public void OnUnityAdsDidError(string message)
    {

    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished && placementId == myPlacementId)
        {
            SetBg();
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
