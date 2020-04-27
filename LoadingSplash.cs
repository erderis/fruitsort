using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingSplash : MonoBehaviour
{
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
        SceneManager.LoadScene("Level101");
    }
}
