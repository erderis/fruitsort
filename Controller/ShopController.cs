using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ShopController : MonoBehaviour
{
    public GameObject canvasPreview;

    GameObject panel;
    GameObject canvasTheme;
    public GameObject[] videoIcons;

   


    void Start()
    {
        canvasTheme = GameObject.Find("Canvas Theme");
        canvasPreview.SetActive(false);


        CheckIfLevelComplete();

    }

    void CheckIfLevelComplete()
    {
        string isLevel50 = PlayerPrefs.GetString("level50", "false");
        string isLevel100 = PlayerPrefs.GetString("level100", "false");
        string isLevel150 = PlayerPrefs.GetString("level150", "false");
        string isLevel200 = PlayerPrefs.GetString("level200", "false");

        if (isLevel50 == "true")
        {
            GameObject fruit6 = GameObject.FindWithTag("fruit6");
            GameObject levelText = fruit6.transform.GetChild(1).gameObject;
            levelText.SetActive(false);
        }
        if (isLevel100 == "true")
        {
            GameObject fruit7 = GameObject.FindWithTag("fruit7");
            GameObject levelText = fruit7.transform.GetChild(1).gameObject;
            levelText.SetActive(false);
        }
        if (isLevel150 == "true")
        {
            GameObject fruit8 = GameObject.FindWithTag("fruit8");
            GameObject levelText = fruit8.transform.GetChild(1).gameObject;
            levelText.SetActive(false);
        }
        if (isLevel200 == "true")
        {
            GameObject fruit9 = GameObject.FindWithTag("fruit9");
            GameObject levelText = fruit9.transform.GetChild(1).gameObject;
            levelText.SetActive(false);
        }
    }

    void Update()
    {
        
    }

    public void ShowPreview(Sprite background)
    {
        Physics2D.gravity = new Vector2(0, -15f);
        canvasTheme.SetActive(false);
        canvasPreview.SetActive(true);
        panel = canvasPreview.transform.GetChild(1).gameObject;
        panel.GetComponent<Image>().sprite = background;
    }


    public void closeCanvasPreview()
    {
        canvasPreview.SetActive(false);
        canvasTheme.SetActive(true);
    }

    public void SetFruit(GameObject newGO)
    {
        if (newGO.tag == "fruit1")
        {
            SetFruitNext(newGO);
        }

        else if(newGO.tag == "fruit6")
        {
            string isLevel50 = PlayerPrefs.GetString("level50", "false");

            if(isLevel50 == "true")
            {
                SetFruitNext(newGO);
            }
            else
            {
                return;
            }
        }
        else if (newGO.tag == "fruit7")
        {
                string isLevel50 = PlayerPrefs.GetString("level100", "false");

                if (isLevel50 == "true")
                {
                    SetFruitNext(newGO);
                }
                else
                {
                    return;
                }
         }
        else if (newGO.tag == "fruit8")
        {
            string isLevel50 = PlayerPrefs.GetString("level150", "false");

            if (isLevel50 == "true")
            {
                SetFruitNext(newGO);
            }
            else
            {
                return;
            }
        }
        else if (newGO.tag == "fruit9")
        {
            string isLevel50 = PlayerPrefs.GetString("level200", "false");

            if (isLevel50 == "true")
            {
                SetFruitNext(newGO);
            }
            else
            {
                return;
            }
        }
    }

    void SetFruitNext(GameObject newGO)
    {
        string nameTag = PlayerPrefs.GetString("fruitTag", "fruit1");

        GameObject currentGO = GameObject.FindWithTag(nameTag);

        GameObject check = currentGO.transform.GetChild(0).gameObject;
        check.SetActive(false);

        GameObject newCheck = newGO.transform.GetChild(0).gameObject;
        newCheck.SetActive(true);

        PlayerPrefs.SetString("fruitTag", newGO.tag);
    }


    public void SetBackground(GameObject newGO)
    {
      

        string nameTag = PlayerPrefs.GetString("bgTag", "default");

        GameObject currentGO = GameObject.FindWithTag(nameTag);

        currentGO.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Use";
        GameObject check = currentGO.transform.GetChild(1).gameObject;
        check.SetActive(false);

        newGO.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Used    ";
        GameObject newCheck = newGO.transform.GetChild(1).gameObject;
        newCheck.SetActive(true);


        PlayerPrefs.SetString("bgTag", newGO.tag);



    }


    public void CloseTheme()
    {
        string lastToTheme = PlayerPrefs.GetString("lastToTheme", "Level2");
        SceneManager.LoadScene(lastToTheme);


        PlayerPrefs.SetString("isBackFromThemeToCanvasReview", "true");

        PlayerPrefs.SetString("isBackFromThemeToCanvasKeepWatching", "true");


    }
}
