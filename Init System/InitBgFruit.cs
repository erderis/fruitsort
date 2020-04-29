using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBgFruit : MonoBehaviour
{
    void Start()
    {
        Invoke("InitBgFruits", 0.3f);
    }


    void InitBgFruits()
    {
        string bgTag = PlayerPrefs.GetString("bgTag", "default");
        string fruitTag = PlayerPrefs.GetString("fruitTag", "fruit1");

        Debug.Log(fruitTag);
        Sprite bgSprite = Resources.Load<Sprite>("background/" + bgTag);
        GetComponent<SpriteRenderer>().sprite = bgSprite;

        Sprite[] fruitSprite = Resources.LoadAll<Sprite>("Fruit/" + fruitTag);
        GameObject[] fruitOrange = GameObject.FindGameObjectsWithTag("orange");
        GameObject[] fruitBanana = GameObject.FindGameObjectsWithTag("banana");
        GameObject[] fruitCherry = GameObject.FindGameObjectsWithTag("cherry");
        GameObject[] fruitMelon = GameObject.FindGameObjectsWithTag("melon");
        GameObject[] fruitApple = GameObject.FindGameObjectsWithTag("apple");
        GameObject[] fruitstrawberry = GameObject.FindGameObjectsWithTag("strawberry");
        GameObject[] fruitEggplant = GameObject.FindGameObjectsWithTag("eggplant");
        GameObject[] fruitPumpkin = GameObject.FindGameObjectsWithTag("pumpkin");
        GameObject[] fruitGrape = GameObject.FindGameObjectsWithTag("grape");

        if (fruitOrange.Length != 0)
        {
            foreach (GameObject fruit in fruitOrange)
            {
                fruit.GetComponent<SpriteRenderer>().sprite = fruitSprite[0];
            }
        }
        if (fruitCherry.Length != 0)
        {
            foreach (GameObject fruit in fruitCherry)
            {
                fruit.GetComponent<SpriteRenderer>().sprite = fruitSprite[1];
            }
        }
        if (fruitBanana.Length != 0)
        {
            foreach (GameObject fruit in fruitBanana)
            {
                fruit.GetComponent<SpriteRenderer>().sprite = fruitSprite[2];
            }
        }
        if (fruitApple.Length != 0)
        {
            foreach (GameObject fruit in fruitApple)
            {
                fruit.GetComponent<SpriteRenderer>().sprite = fruitSprite[3];
            }
        }
        if (fruitMelon.Length != 0)
        {
            foreach (GameObject fruit in fruitMelon)
            {
                fruit.GetComponent<SpriteRenderer>().sprite = fruitSprite[4];
            }
        }
        if (fruitstrawberry.Length != 0)
        {
            foreach (GameObject fruit in fruitstrawberry)
            {
                fruit.GetComponent<SpriteRenderer>().sprite = fruitSprite[5];
            }
        }
        if (fruitEggplant.Length != 0)
        {
            foreach (GameObject fruit in fruitEggplant)
            {
                fruit.GetComponent<SpriteRenderer>().sprite = fruitSprite[6];
            }
        }
        if (fruitPumpkin.Length != 0)
        {
            foreach (GameObject fruit in fruitPumpkin)
            {
                fruit.GetComponent<SpriteRenderer>().sprite = fruitSprite[7];
            }
        }
        if (fruitGrape.Length != 0)
        {
            foreach (GameObject fruit in fruitGrape)
            {
                fruit.GetComponent<SpriteRenderer>().sprite = fruitSprite[8];
            }
        }

    }

}
