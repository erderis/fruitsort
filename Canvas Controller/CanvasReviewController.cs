using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasReviewController : MonoBehaviour
{
    Button later;
    Button rateIt;

    void Start()
    {
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
        Destroy(transform.gameObject, 0);
    }
    void RateGo()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.derisdev.FruitSortStack");
        Destroy(transform.gameObject, 0);


    }

}
