using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingSplash : MonoBehaviour
{
    public GameObject music;
    void Start()
    {
        PlayerPrefs.SetString("repeat", null);
        Invoke("LoadLevel", 5f);
    }

    void Update()
    {
        
    }

    void LoadLevel()
    {
        Instantiate(music, transform.position, Quaternion.identity);
        string levelNow = PlayerPrefs.GetString("LevelNow", "Level1");

        SceneManager.LoadScene(levelNow);
    }
}
