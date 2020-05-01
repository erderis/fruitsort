using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasReviewController : MonoBehaviour
{
    GameObject music;
    Button later;
    Button rateIt;

    void Start()
    {
        music = GameObject.FindWithTag("music");

        later = transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Button>();
        rateIt = transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Button>();

        later.onClick.AddListener(CloseReview);

        rateIt.onClick.AddListener(RateGo);

        string isBackFromTheme = PlayerPrefs.GetString("isBackFromThemeToCanvasReview", "false");
        if(isBackFromTheme == "true")
        {
            Destroy(transform.gameObject, 0);
            PlayerPrefs.SetString("isBackFromThemeToCanvasReview", "false");
        }
    }

    void CloseReview()
    {
        music.GetComponent<MusicClass>().ButtonSound();
        Destroy(transform.gameObject, 0);
    }
    void RateGo()
    {
        music.GetComponent<MusicClass>().ButtonSound();
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.derisdev.FruitSortStack");
        Destroy(transform.gameObject, 0);


    }

}
