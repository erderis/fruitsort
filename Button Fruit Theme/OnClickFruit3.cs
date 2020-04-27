using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class OnClickFruit3 : MonoBehaviour, IUnityAdsListener
{

    string gameId = "3524520";
    string myPlacementId = "Fruit_Theme3";
    bool testMode = true;

    bool isReady = false;

    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, testMode);

    }

    void Update()
    {
        
    }

    public void OnClicked()
    {
        string isShowAds = PlayerPrefs.GetString("AdsFruit3", "false");

        if(isShowAds == "false")
        {
            if (isReady)
            {
                Advertisement.Show(myPlacementId);
            }
        }
        else
        {
            SetFruit();
        }
        
    }

    void SetFruit()
    {

        string nameTag = PlayerPrefs.GetString("fruitTag", "fruit1");

        GameObject currentGO = GameObject.FindWithTag(nameTag);

        GameObject check = currentGO.transform.GetChild(0).gameObject;
        check.SetActive(false);

        GameObject newCheck = transform.GetChild(0).gameObject;
        newCheck.SetActive(true);

        PlayerPrefs.SetString("fruitTag", transform.tag);

        Debug.Log(transform.tag);


        GameObject ads = transform.GetChild(1).gameObject;
        ads.SetActive(false);

        PlayerPrefs.SetString("AdsFruit3", "true");

    }



    public void OnUnityAdsDidError(string message)
    {

    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished && placementId == myPlacementId)
        {
            SetFruit();
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
