using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasKeepWatching : MonoBehaviour
{
    GameObject iapManager;
    GameObject music;


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
        music = GameObject.FindWithTag("music");


        keepWatching = transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Button>();
        removeAds = transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Button>();

        keepWatching.onClick.AddListener(KeepWatching);

        removeAds.onClick.AddListener(RemoveAds);



    }

    void KeepWatching()
    {
        music.GetComponent<MusicClass>().ButtonSound();
        Destroy(transform.gameObject, 0);
    }

    void RemoveAds()
    {
        music.GetComponent<MusicClass>().ButtonSound();
        iapManager.GetComponent<IAPManager>().BuyRemoveAds();
        Destroy(transform.gameObject, 0);

    }

}
