﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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


            string currentScene = SceneManager.GetActiveScene().name;
            char[] splitScene = currentScene.ToCharArray();

            string isLevel10 = PlayerPrefs.GetString("isLevel10", "false");
            string isLevel100 = PlayerPrefs.GetString("isLevel100", "false");

            int numberNext;

            if (isLevel10 == "true")
            {
                int num1 = int.Parse(splitScene[splitScene.Length - 2].ToString());
                int num2 = int.Parse(splitScene[splitScene.Length - 1].ToString());
                numberNext = int.Parse(num1.ToString() + num2.ToString()) + 1;

            }
            else if (isLevel100 == "true")
            {
                int num1 = int.Parse(splitScene[splitScene.Length - 3].ToString());
                int num2 = int.Parse(splitScene[splitScene.Length - 2].ToString());
                int num3 = int.Parse(splitScene[splitScene.Length - 1].ToString());
                numberNext = int.Parse(num1.ToString() + num2.ToString() + num3.ToString()) + 1;

            }
            else
            {
                numberNext = int.Parse(splitScene[splitScene.Length - 1].ToString()) + 1;
            }

            string nextLevel = "Level" + numberNext.ToString();


            PlayerPrefs.SetString("LevelNow", nextLevel);
        }
    }

}
