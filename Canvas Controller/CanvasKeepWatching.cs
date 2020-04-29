using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasKeepWatching : MonoBehaviour
{
    GameObject iapManager;


    Button keepWatching;
    Button removeAds;

    void Start()
    {

        string isPurchased = PlayerPrefs.GetString("isAdPurchased", "false");

        if (isPurchased == "true")
        {
            Destroy(transform.gameObject, 0);

        }

        string isBackFromTheme = PlayerPrefs.GetString("isBackFromThemeToCanvasKeepWatching", "false");
        if (isBackFromTheme == "true")
        {
            Destroy(transform.gameObject, 0);
            PlayerPrefs.SetString("isBackFromThemeToCanvasKeepWatching", "false");
        }

        iapManager = GameObject.FindWithTag("IAP Manager");


        keepWatching = transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Button>();
        removeAds = transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Button>();

        keepWatching.onClick.AddListener(KeepWatching);

        removeAds.onClick.AddListener(RemoveAds);



    }

    void KeepWatching()
    {
        Destroy(transform.gameObject, 0);
    }

    void RemoveAds()
    {
        iapManager.GetComponent<IAPManager>().BuyRemoveAds();

        Destroy(transform.gameObject, 0);

    }

}
