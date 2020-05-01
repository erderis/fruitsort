using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasStartController : MonoBehaviour
{
    GameObject background;
    GameObject iapManager;
    GameObject imageStage;
    GameObject panelNotif;
    GameObject buttonNoAds;
    GameObject panelSuccess;
    GameObject setting;
    GameObject panelMusic;
    GameObject music;

    GameObject checkSound;
    GameObject checkMusic;

    Button buttonAds;
    Button buttonTheme;
    Button textStart;

    Button buyPremium;
    Button close;
    Button closePanelSuccess;
    Button settingButton;
    Button closeSetting;

    Button soundBtn;
    Button musicBtn;

    bool isLoaded = false;
    void Start()
    {
        background = GameObject.FindWithTag("background");
        iapManager = GameObject.FindWithTag("IAP Manager");
        music = GameObject.FindWithTag("music");
        imageStage = transform.GetChild(1).gameObject;
        buttonNoAds = transform.GetChild(2).gameObject;
        panelNotif = transform.GetChild(5).gameObject;
        panelSuccess = transform.GetChild(6).gameObject;
        setting = transform.GetChild(7).gameObject;
        buttonAds = transform.GetChild(2).GetComponent<Button>();
        buttonTheme = transform.GetChild(3).GetComponent<Button>();
        textStart = transform.GetChild(4).GetComponent<Button>();

        buyPremium = panelNotif.transform.GetChild(0).GetChild(1).GetComponent<Button>();
        close = panelNotif.transform.GetChild(0).GetChild(2).GetComponent<Button>();
        closePanelSuccess = panelSuccess.transform.GetChild(0).GetChild(1).GetComponent<Button>();
        panelMusic = setting.transform.GetChild(0).gameObject;
        settingButton = setting.GetComponent<Button>();
        closeSetting = panelMusic.transform.GetChild(0).GetChild(4).GetComponent<Button>();

        soundBtn = panelMusic.transform.GetChild(0).GetChild(1).GetComponent<Button>();
        musicBtn = panelMusic.transform.GetChild(0).GetChild(3).GetComponent<Button>();

        checkSound = soundBtn.transform.GetChild(1).gameObject;
        checkMusic = musicBtn.transform.GetChild(1).gameObject;

        string currentScene = SceneManager.GetActiveScene().name;
        char[] splitScene = currentScene.ToCharArray();

        if (currentScene == "Level2")
        {
            PlayerPrefs.SetString("isLevel2", "true");
            PlayerPrefs.SetString("isLevel10", "false");
            PlayerPrefs.SetString("isLevel100", "false");

        }
        if (currentScene == "Level10")
        {
            PlayerPrefs.SetString("isLevel10", "true");
            PlayerPrefs.SetString("isLevel2", "false");
            PlayerPrefs.SetString("isLevel100", "false");
        }
        if (currentScene == "Level100")
        {
            PlayerPrefs.SetString("isLevel100", "true");
            PlayerPrefs.SetString("isLevel10", "false");
            PlayerPrefs.SetString("isLevel2", "false");

        }
        string isLevel2 = PlayerPrefs.GetString("isLevel2", "false");
        string isLevel10 = PlayerPrefs.GetString("isLevel10", "false");
        string isLevel100 = PlayerPrefs.GetString("isLevel100", "false");

        int numberNext = int.Parse(splitScene[splitScene.Length - 1].ToString());

        if (isLevel10 == "true")
        {
            int num1 = int.Parse(splitScene[splitScene.Length - 2].ToString());
            int num2 = int.Parse(splitScene[splitScene.Length - 1].ToString());
            numberNext = int.Parse(num1.ToString()+num2.ToString());

            imageStage.transform.GetChild(0).GetComponent<Text>().fontSize = 60;
            imageStage.transform.GetChild(1).GetComponent<Text>().fontSize = 60;

        }
        else if(isLevel100 == "true")
        {
            int num1 = int.Parse(splitScene[splitScene.Length - 3].ToString());
            int num2 = int.Parse(splitScene[splitScene.Length - 2].ToString());
            int num3 = int.Parse(splitScene[splitScene.Length - 1].ToString());
            numberNext = int.Parse(num1.ToString() + num2.ToString()+num3.ToString());

            imageStage.transform.GetChild(0).GetComponent<Text>().fontSize = 50;
            imageStage.transform.GetChild(1).GetComponent<Text>().fontSize = 50;

        }
        else
        {
            numberNext = int.Parse(splitScene[splitScene.Length - 1].ToString());
        }


        imageStage.transform.GetChild(0).GetComponent<Text>().text = numberNext.ToString();
        imageStage.transform.GetChild(1).GetComponent<Text>().text = (numberNext + 1).ToString();

        buttonAds.onClick.AddListener(buttonAdsOnClick);
        buttonTheme.onClick.AddListener(buttonThemeOnClick);
        textStart.onClick.AddListener(buttonStartOnClick);
        settingButton.onClick.AddListener(buttonSettingOnClick);
        closeSetting.onClick.AddListener(buttonCloseSettingOnClick);
        
        soundBtn.onClick.AddListener(buttonSoundOnClick);
        musicBtn.onClick.AddListener(buttonMusicOnClick);

        buyPremium.onClick.AddListener(buttonSAdsPremiumOnClick);
        close.onClick.AddListener(buttonCloseOnClick);
        closePanelSuccess.onClick.AddListener(buttonCloseSuccessOnClick);


        string isSoundMuted = PlayerPrefs.GetString("isMusicMuted", "false");
        string isMusicMuted = PlayerPrefs.GetString("isMusicMuted", "false");

        if (isSoundMuted == "false")
        {
            checkSound.SetActive(true);
        }
        else
        {
            checkSound.SetActive(false);
        }

        if (isMusicMuted == "false")
        {
            checkMusic.SetActive(true);
        }
        else
        {
            checkMusic.SetActive(false);

        }

    }

    void buttonAdsOnClick()
    {
        music.GetComponent<MusicClass>().ButtonSound();
        panelNotif.SetActive(true);
    }

    void buttonThemeOnClick()
    {
        music.GetComponent<MusicClass>().ButtonSound();
        background.GetComponent<NavigationController>().LoadTheme();
    }

    void buttonStartOnClick()
    {
        music.GetComponent<MusicClass>().ButtonSound();
        background.GetComponent<NavigationController>().TextStart();
    }

    void buttonSAdsPremiumOnClick()
    {
        music.GetComponent<MusicClass>().ButtonSound();
        panelNotif.SetActive(false);
        iapManager.GetComponent<IAPManager>().BuyRemoveAds();

    }
    void buttonCloseOnClick()
    {
        music.GetComponent<MusicClass>().ButtonSound();
        panelNotif.SetActive(false);
    }
    void buttonCloseSuccessOnClick()
    {
        music.GetComponent<MusicClass>().ButtonSound();
        panelSuccess.SetActive(false);
    }

    void buttonSettingOnClick()
    {
        music.GetComponent<MusicClass>().ButtonSound();
        panelMusic.SetActive(true);
    }

    void buttonCloseSettingOnClick()
    {
        music.GetComponent<MusicClass>().ButtonSound();
        panelMusic.SetActive(false);
    }

    void buttonSoundOnClick()
    {
        music.GetComponent<MusicClass>().ButtonSound();

        string isSoundMuted = PlayerPrefs.GetString("isMusicMuted", "false");

        if(isSoundMuted == "true")
        {
            checkSound.SetActive(true);

            music.GetComponent<MusicClass>().GiveSound();

            PlayerPrefs.SetString("isMusicMuted", "false");
        }
        else
        {
            checkSound.SetActive(false);

            music.GetComponent<MusicClass>().MuteSound();

            PlayerPrefs.SetString("isMusicMuted", "true");
        }
       

    }


    void buttonMusicOnClick()
    {
        music.GetComponent<MusicClass>().ButtonSound();

        string isMusicMuted = PlayerPrefs.GetString("isMusicMuted", "false");

        if (isMusicMuted == "true")
        {
            checkMusic.SetActive(true);

            music.GetComponent<MusicClass>().GiveMusic();

            PlayerPrefs.SetString("isMusicMuted", "false");
        }
        else
        {
            checkMusic.SetActive(false);

            music.GetComponent<MusicClass>().MuteMusic();

            PlayerPrefs.SetString("isMusicMuted", "true");
        }

    }





    void Update()
    {

        string isPurchased = PlayerPrefs.GetString("isAdPurchased", "false");
        string isShowSuccessOnce = PlayerPrefs.GetString("isShowSuccessOnce", "true");

        if(isPurchased == "true")
        {

            if (!isLoaded)
            {
                buttonNoAds.SetActive(false);
                isLoaded = true;
            }

            if(isShowSuccessOnce == "true")
            {
                //show notif success
                panelSuccess.SetActive(true);
                PlayerPrefs.SetString("isShowSuccessOnce", "false");
            }
        }

    }
}
