using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSuccessLv101 : MonoBehaviour
{
    public GameObject canvasButton;
    public GameObject canvasSuccess;
    public GameObject particleConfetti;

    bool isLoaded = false;

    GameObject cSuccess;
    GameObject pConfetti;

    void Start()
    {


        cSuccess = Instantiate(canvasSuccess, transform.position, Quaternion.identity);
        pConfetti = Instantiate(particleConfetti, transform.position, Quaternion.identity);

        cSuccess.SetActive(false);
        pConfetti.SetActive(false);



        PlayerPrefs.SetInt("orange", 0);
        PlayerPrefs.SetInt("cherry", 0);
        PlayerPrefs.SetInt("banana", 0);
        PlayerPrefs.SetInt("apple", 0);
        PlayerPrefs.SetInt("melon", 0);
        PlayerPrefs.SetInt("strawberry", 0);
        PlayerPrefs.SetInt("eggplant", 0);
        PlayerPrefs.SetInt("pumpkin", 0);
        PlayerPrefs.SetInt("grape", 0);
        PlayerPrefs.SetInt("blackberry", 0);
        PlayerPrefs.SetInt("blueberry", 0);
        PlayerPrefs.SetInt("manggoes", 0);
    }

    // Update is called once per frame
    void Update()
    {
        int tagOrange = PlayerPrefs.GetInt("orange");
        int tagCherry = PlayerPrefs.GetInt("cherry");
        int tagBanana = PlayerPrefs.GetInt("banana");
        int tagMelon = PlayerPrefs.GetInt("melon");
        int tagApple = PlayerPrefs.GetInt("apple");
        int tagStrawberry = PlayerPrefs.GetInt("strawberry");
        int tagPumpkin = PlayerPrefs.GetInt("pumpkin");
        int tagGrape = PlayerPrefs.GetInt("grape");
        int tagBlackBerry = PlayerPrefs.GetInt("blackberry");
        int tagBlueBerry = PlayerPrefs.GetInt("blueberry");
        int tagManggoes = PlayerPrefs.GetInt("manggoes");


        if (tagOrange == 1 && tagCherry == 1 && tagBanana == 1 && tagApple == 1 && tagMelon == 1 && tagPumpkin == 1 && tagGrape == 1 && tagBlackBerry == 1 && tagBlueBerry == 1 && tagManggoes ==1)
        {
            if (!isLoaded)
            {
                cSuccess.SetActive(true);
                pConfetti.SetActive(true);
                canvasButton.SetActive(false);
                PlayerPrefs.SetString("repeat", null);

                PlayerPrefs.SetInt("orange", 0);
                PlayerPrefs.SetInt("cherry", 0);
                PlayerPrefs.SetInt("banana", 0);
                PlayerPrefs.SetInt("apple", 0);
                PlayerPrefs.SetInt("melon", 0);
                PlayerPrefs.SetInt("strawberry", 0);
                PlayerPrefs.SetInt("eggplant", 0);
                PlayerPrefs.SetInt("pumpkin", 0);
                PlayerPrefs.SetInt("grape", 0);
                PlayerPrefs.SetInt("blackberry", 0);
                PlayerPrefs.SetInt("blueberry", 0);
                PlayerPrefs.SetInt("manggoes", 0);

                isLoaded = true;
            }

        }
    }

}
