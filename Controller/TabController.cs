using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    public GameObject[] videoIcons;
    public GameObject tab1;
    public GameObject tab2;

    public GameObject tabView1;
    public GameObject tabView2;

    public Sprite tabColor1;
    public Sprite tabColor2;

    GameObject music;


    void Start()
    {
        music = GameObject.FindWithTag("music");
        tabView1.SetActive(true);
        tabView2.SetActive(false);
        
        InitFruit();


    }

    void Update()
    {
        
    }
    public void Tab1Clicked()
    {
        music.GetComponent<MusicClass>().ButtonSound();

        tabView1.SetActive(true);
        tabView2.SetActive(false);

        tab1.GetComponent<Image>().sprite = tabColor2;
        tab2.GetComponent<Image>().sprite = tabColor1;

        InitFruit();

    }

    public void Tab2Clicked()
    {
        music.GetComponent<MusicClass>().ButtonSound();

        tabView1.SetActive(false);
        tabView2.SetActive(true);

        tab1.GetComponent<Image>().sprite = tabColor1;
        tab2.GetComponent<Image>().sprite = tabColor2;

        InitBg();
    }


    void InitFruit()
    {
        string nameTag = PlayerPrefs.GetString("fruitTag", "fruit1");


        GameObject currentGO = GameObject.FindWithTag(nameTag);

        GameObject newCheck = currentGO.transform.GetChild(0).gameObject;
        newCheck.SetActive(true);

        string isShowAds2 = PlayerPrefs.GetString("AdsFruit2", "false");
        string isShowAds3 = PlayerPrefs.GetString("AdsFruit3", "false");
        string isShowAds4 = PlayerPrefs.GetString("AdsFruit4", "false");
        string isShowAds5 = PlayerPrefs.GetString("AdsFruit5", "false");
        string isLevel50 = PlayerPrefs.GetString("level50", "false");
        string isLevel100 = PlayerPrefs.GetString("level100", "false");
        string isLevel150 = PlayerPrefs.GetString("level150", "false");
        string isLevel200 = PlayerPrefs.GetString("level200", "false");

        if (isShowAds2 == "true")
        {
            GameObject fruit2 = GameObject.FindWithTag("fruit2");
            GameObject ads = fruit2.transform.GetChild(1).gameObject;
            ads.SetActive(false);
        }
        if (isShowAds3 == "true")
        {
            GameObject fruit3 = GameObject.FindWithTag("fruit3");
            GameObject ads = fruit3.transform.GetChild(1).gameObject;
            ads.SetActive(false);
        }
        if (isShowAds4 == "true")
        {
            GameObject fruit4 = GameObject.FindWithTag("fruit4");
            GameObject ads = fruit4.transform.GetChild(1).gameObject;
            ads.SetActive(false);
        }
        if (isShowAds5 == "true")
        {
            GameObject fruit5 = GameObject.FindWithTag("fruit5");
            GameObject ads = fruit5.transform.GetChild(1).gameObject;
            ads.SetActive(false);
        }
        if (isLevel50 == "true")
        {
            GameObject fruit6 = GameObject.FindWithTag("fruit6");
            GameObject ads = fruit6.transform.GetChild(1).gameObject;
            ads.SetActive(false);
        }
        if (isLevel100 == "true")
        {
            GameObject fruit7 = GameObject.FindWithTag("fruit7");
            GameObject ads = fruit7.transform.GetChild(1).gameObject;
            ads.SetActive(false);
        }
        if (isLevel150 == "true")
        {
            GameObject fruit8 = GameObject.FindWithTag("fruit8");
            GameObject ads = fruit8.transform.GetChild(1).gameObject;
            ads.SetActive(false);
        }
        if (isLevel200 == "true")
        {
            GameObject fruit9 = GameObject.FindWithTag("fruit9");
            GameObject ads = fruit9.transform.GetChild(1).gameObject;
            ads.SetActive(false);
        }



    }


    void InitBg()
    {
        string nameTag = PlayerPrefs.GetString("bgTag", "default");

        GameObject currentGO = GameObject.FindWithTag(nameTag);

        currentGO.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Used    ";
        GameObject coin = currentGO.transform.GetChild(1).gameObject;
        coin.SetActive(true);

        string isShowAds1 = PlayerPrefs.GetString("AdsBg1", "false");
        string isShowAds2 = PlayerPrefs.GetString("AdsBg2", "false");
        string isShowAds3 = PlayerPrefs.GetString("AdsBg3", "false");
        string isShowAds4 = PlayerPrefs.GetString("AdsBg4", "false");
        string isShowAds5 = PlayerPrefs.GetString("AdsBg5", "false");

        if (isShowAds1 == "true")
        {
            GameObject bg1 = GameObject.FindWithTag("background1");
            GameObject ads = bg1.transform.GetChild(2).gameObject;
            ads.SetActive(false);
        }
        if (isShowAds2 == "true")
        {
            GameObject bg2 = GameObject.FindWithTag("background2");
            GameObject ads = bg2.transform.GetChild(2).gameObject;
            ads.SetActive(false);
        }
        if (isShowAds3 == "true")
        {
            GameObject bg3 = GameObject.FindWithTag("background3");
            GameObject ads = bg3.transform.GetChild(2).gameObject;
            ads.SetActive(false);
        }
        if (isShowAds4 == "true")
        {
            GameObject bg4 = GameObject.FindWithTag("background4");
            GameObject ads = bg4.transform.GetChild(2).gameObject;
            ads.SetActive(false);
        }
        if (isShowAds5 == "true")
        {
            GameObject bg5 = GameObject.FindWithTag("background5");
            GameObject ads = bg5.transform.GetChild(2).gameObject;
            ads.SetActive(false);
        }
    }

}
