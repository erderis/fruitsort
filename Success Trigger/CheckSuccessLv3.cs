﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSuccessLv3 : MonoBehaviour
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
    }

    // Update is called once per frame
    void Update()
    {
        int tagOrange = PlayerPrefs.GetInt("orange");
        int tagCherry = PlayerPrefs.GetInt("cherry");
        int tagBanana = PlayerPrefs.GetInt("banana");

        if (tagOrange == 1 && tagCherry == 1 && tagBanana == 1)
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

                isLoaded = true;
            }

        }
    }

}