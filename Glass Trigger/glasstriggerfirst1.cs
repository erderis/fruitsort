using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class glasstriggerfirst1 : MonoBehaviour
{

    List<Collider2D> listCollider;

    public GameObject particle;
    public GameObject hand;
    public GameObject canvasSuccess;
    public GameObject canvasButton;
    public GameObject particleConfetti;
    
    public GameObject music;


    public Text text;



    void Start()
    {
        listCollider = new List<Collider2D>();
        PlayerPrefs.SetInt("onMove", 0);
        PlayerPrefs.SetInt("glass1", 0);
        particle.SetActive(false);
        canvasSuccess.SetActive(false);
        particleConfetti.SetActive(false);

        music = GameObject.FindWithTag("music");


    }

    // Update is called  per frame
    void Update()
    {
        Invoke("setGlass", 2f);

    }

    void setGlass()
    {
        if (listCollider.Count == 4)
        {
            if (listCollider[0].gameObject.tag == listCollider[1].gameObject.tag
            && listCollider[1].gameObject.tag == listCollider[2].gameObject.tag
            && listCollider[2].gameObject.tag == listCollider[3].gameObject.tag)
            {
                PlayerPrefs.SetInt("glass1", 1);
                particle.SetActive(true);

            }
        }
        else if (listCollider.Count == 0)
        {
            PlayerPrefs.SetInt("glass1", 1);

        }
        else
        {
            PlayerPrefs.SetInt("glass1", 0);

        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        listCollider.Add(collider);
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        listCollider.Remove(collider);
    }


    void OnMouseDown()
    {

        if(!IsPointerOverUIObject())
        {
            string clicked = PlayerPrefs.GetString("clicked");
            if (clicked!= "clicked")
            {

            }
            else
            {
                bool onMove = PlayerPrefs.GetInt("onMove") == 1 ? true : false;


                if (!onMove)
                {
                    if (listCollider.Count > 0)
                    {
                        string collidername = listCollider[listCollider.Count - 1].gameObject.name;
                        PlayerPrefs.SetString("collidername", collidername);
                        GameObject fruit = GameObject.Find(collidername);
                        fruit.transform.position = new Vector3(transform.position.x, transform.position.y + 11.5f, transform.position.z + 1);
                        fruit.GetComponent<Rigidbody2D>().gravityScale = 0;
                        onMove = true;
                        PlayerPrefs.SetInt("onMove", onMove ? 1 : 0);

                        hand.transform.position = new Vector3(9.52f, -10.01308f, -3.372642f);
                        text.text = "Click to Move Fruit";

                        music.GetComponent<MusicClass>().FruitUpSound();

                    }
                }

                else
                {
                    string collidername = PlayerPrefs.GetString("collidername");
                    GameObject fruit = GameObject.Find(collidername);
                    if (listCollider.Count > 0)
                    {
                        if (fruit.tag == listCollider[listCollider.Count - 1].tag && listCollider.Count < 4)
                        {
                            fruit.transform.position = new Vector3(transform.position.x, transform.position.y + 11.5f, transform.position.z + 1);
                            fruit.GetComponent<Rigidbody2D>().gravityScale = 20;
                            hand.SetActive(false);
                            text.text = "";
                            canvasSuccess.SetActive(true);
                            canvasButton.SetActive(false);
                            particleConfetti.SetActive(true);
                            PlayerPrefs.SetString("repeat", null);

                            music.GetComponent<MusicClass>().WinSound();

                        }

                        else
                        {
                            fruit.GetComponent<Rigidbody2D>().gravityScale = 20;
                            music.GetComponent<MusicClass>().FruitUpSound();

                        }
                    }
                    else
                    {
                        fruit.transform.position = new Vector3(transform.position.x, transform.position.y + 11.5f, transform.position.z + 1);
                        fruit.GetComponent<Rigidbody2D>().gravityScale = 20;
                        music.GetComponent<MusicClass>().FruitUpSound();

                    }
                    onMove = false;
                    PlayerPrefs.SetInt("onMove", onMove ? 1 : 0);
                    PlayerPrefs.SetString("collidername", null);
                }
            }
        }

    }

    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);

        return results.Count > 0;
    }

    public void LoadLevel()
    {
        music.GetComponent<MusicClass>().ButtonSound();

        SceneManager.LoadScene("level2");
    }
}
