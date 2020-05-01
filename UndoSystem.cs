using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;

public class UndoSystem : MonoBehaviour, IUnityAdsListener
{
    public List<setting> UndoList;
    public GameObject adsIcon;
    public GameObject undoCount;
    public GameObject music;


    string gameId = "3524520";
    string myPlacementId = "Undo_Rewards";
    bool testMode = false;
    bool isReady = false;


    public class setting
    {
        public GameObject Obj;
        public Vector3 Pos;
        public float scale;
        public bool Deleted;

        public void Restore()
        {
            Obj.transform.position = Pos;
            Obj.GetComponent<Rigidbody2D>().gravityScale = scale;
            Obj.SetActive(Deleted);
        }
        public setting(GameObject g)
        {
            Obj = g;
            Pos = g.transform.position;
            scale = g.GetComponent<Rigidbody2D>().gravityScale;
            Deleted = g.activeSelf;

        }
    }



    public void AddUndo(GameObject g)
    {
        setting s = new setting(g);
        UndoList.Add(s);
    }

    public void Undo()
    {

            int currentClickedUndo = PlayerPrefs.GetInt("currentClickedUndo", 5);
            if (currentClickedUndo == 1)
            {
                adsIcon.SetActive(true);
            }
            if (currentClickedUndo == 0)
            {
                if(isReady)
                {
                    //show ads
                    Advertisement.Show(myPlacementId);
                }

            }
            else
            {
                if (UndoList.Count > 0)
                {

                music.GetComponent<MusicClass>().FruitUpSound();

                UndoList[UndoList.Count - 1].Restore();
                    UndoList.RemoveAt(UndoList.Count - 1);

                    PlayerPrefs.SetInt("onMove", 0);


                    currentClickedUndo -= 1;
                    undoCount.GetComponent<Text>().text = currentClickedUndo.ToString();
                    PlayerPrefs.SetInt("currentClickedUndo", currentClickedUndo);

                }
            }
        
    }

    void Start()
    {
        music = GameObject.FindWithTag("music");

        adsIcon.SetActive(false);
        UndoList = new List<setting>();

        PlayerPrefs.SetString("isShowingAdsUndo", "false");
        int currentClickedUndo = PlayerPrefs.GetInt("currentClickedUndo", 5);

        undoCount.GetComponent<Text>().text = currentClickedUndo.ToString();

        if(currentClickedUndo == 0)
        {
            adsIcon.SetActive(true);
        }





        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, testMode);

    }

    public void OnUnityAdsReady(string placementId)
    {
        if(myPlacementId == placementId)
        {
            isReady = true;
        }
    }

    public void OnUnityAdsDidError(string message)
    {
    }

    public void OnUnityAdsDidStart(string placementId)
    {

        PlayerPrefs.SetString("isShowingAdsUndo", "true");
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished && placementId==myPlacementId)
        {
            PlayerPrefs.SetString("isShowingAdsUndo", "false");
            adsIcon.SetActive(false);
            PlayerPrefs.SetInt("currentClickedUndo", 5);
            undoCount.GetComponent<Text>().text = "5";
        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }

    }
}