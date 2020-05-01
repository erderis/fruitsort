using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class NavigationController : MonoBehaviour
{

    public GameObject canvasStart;
    public GameObject canvasButton;
    public GameObject canvasFailed;
    public GameObject canvasSaveMe;
    public GameObject timer;
    public GameObject music;
    

    GameObject cStart;
    GameObject cFailed;
    GameObject cSaveMe;


    string gameId = "3524520";
    bool testMode = false;



    // Start is called before the first frame update
    void Start()
    {

        PlayerPrefs.SetString("LevelNow", SceneManager.GetActiveScene().name);

        cStart = Instantiate(canvasStart, transform.position, Quaternion.identity);
        cFailed = Instantiate(canvasFailed, transform.position, Quaternion.identity);
        cSaveMe = Instantiate(canvasSaveMe, transform.position, Quaternion.identity);

        music = GameObject.FindWithTag("music");

        Advertisement.Initialize(gameId, testMode);

        Physics2D.gravity = Vector2.zero;

        canvasButton.SetActive(false);
        cFailed.SetActive(false);
        cSaveMe.SetActive(false);
        timer.SetActive(false);

        string repeat = PlayerPrefs.GetString("repeat");
        if(repeat == "repeat")
        {
            TextStart();
        }



    }

    public void RepeatfromStart()
    {
        music.GetComponent<MusicClass>().ButtonSound();


        string currentScene = SceneManager.GetActiveScene().name;
        cFailed.SetActive(false);
        SceneManager.LoadScene(currentScene);
        PlayerPrefs.SetString("repeat", "repeat");

        PlayerPrefs.SetString("isBackFromThemeToCanvasReview", "true");

    }

    public void TextStart()
    {
        Physics2D.gravity = new Vector2(0, -15f);
        cStart.SetActive(false);
        canvasButton.SetActive(true);
        timer.SetActive(true);

    }

    public void LoadTheme()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("lastToTheme", currentScene);
        SceneManager.LoadScene("Theme");


    }


    public void NextLevel()
    {
        music.GetComponent<MusicClass>().ButtonSound();

        string currentScene = SceneManager.GetActiveScene().name;
        char[] splitScene = currentScene.ToCharArray();

        string isLevel10 = PlayerPrefs.GetString("isLevel10", "false");
        string isLevel100 = PlayerPrefs.GetString("isLevel100", "false");

        int numberNext = int.Parse(splitScene[splitScene.Length - 1].ToString());

        if (isLevel10 == "true")
        {
            int num1 = int.Parse(splitScene[splitScene.Length - 2].ToString());
            int num2 = int.Parse(splitScene[splitScene.Length - 1].ToString());
            numberNext = int.Parse(num1.ToString() + num2.ToString())+1;

        }
        else if (isLevel100 == "true")
        {
            int num1 = int.Parse(splitScene[splitScene.Length - 3].ToString());
            int num2 = int.Parse(splitScene[splitScene.Length - 2].ToString());
            int num3 = int.Parse(splitScene[splitScene.Length - 1].ToString());
            numberNext = int.Parse(num1.ToString() + num2.ToString() + num3.ToString())+1;

        }
        else
        {
            numberNext = int.Parse(splitScene[splitScene.Length - 1].ToString())+1;
        }

        string nextLevel = "Level" + numberNext.ToString();

        int timeForLoadAds = PlayerPrefs.GetInt("timeForLoadAds", 1);

        string isPurchased = PlayerPrefs.GetString("isAdPurchased", "false");
        if (isPurchased == "false")
        {
            if(timeForLoadAds == 1)
            {
                Advertisement.Show("LevelComplete");
                PlayerPrefs.SetInt("timeForLoadAds", 3);
            }
            else
            {
                PlayerPrefs.SetInt("timeForLoadAds", timeForLoadAds--);
            }
        }
        
        SceneManager.LoadScene(nextLevel);

    }

    public void GameOver()
    {
        music.GetComponent<MusicClass>().LostSound();
        cFailed.SetActive(true);
    }

    public void ShowCanvasSaveMe()
    {
        music.GetComponent<MusicClass>().BeforeLostSound();
        cSaveMe.SetActive(true);
    }
    public void HideCanvasSaveMe()
    {
        music.GetComponent<MusicClass>().BeforeLostSoundStop();
        cSaveMe.SetActive(false);
    }
}
