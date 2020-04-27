using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class glasstrigger : MonoBehaviour
{
    List<Collider2D> listCollider;
    GameObject particle;

    public UndoSystem undo;

    void Start()
    {
        particle = transform.GetChild(0).gameObject;
        listCollider = new List<Collider2D>();
        PlayerPrefs.SetInt("onMove", 0);
        PlayerPrefs.SetInt("glass1", 0);
        particle.SetActive(false);

        undo = GameObject.FindWithTag("Undo System").GetComponent<UndoSystem>();
    }

    // Update is called  per frame
    void Update()
    {
        Invoke("SetGlass", 2f);

    }

    void SetGlass()
    {
        if (listCollider.Count == 4)
        {
            if (listCollider[0].gameObject.tag == listCollider[1].gameObject.tag
            && listCollider[1].gameObject.tag == listCollider[2].gameObject.tag
            && listCollider[2].gameObject.tag == listCollider[3].gameObject.tag)
            {
                PlayerPrefs.SetInt(listCollider[0].gameObject.tag, 1);
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
            bool onMove = PlayerPrefs.GetInt("onMove") == 1 ? true : false;


            if (!onMove)
            {
                if (listCollider.Count > 0)
                {
                    string collidername = listCollider[listCollider.Count - 1].gameObject.name;
                    PlayerPrefs.SetString("collidername", collidername);
                    GameObject fruit = GameObject.Find(collidername);

                    undo.AddUndo(fruit);


                    fruit.transform.position = new Vector3(transform.position.x, transform.position.y+8f, transform.position.z+1);
                    fruit.GetComponent<Rigidbody2D>().gravityScale = 0;

                    onMove = true;
                    PlayerPrefs.SetInt("onMove", onMove ? 1 : 0);

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
                        fruit.transform.position = new Vector3(transform.position.x, transform.position.y + 8f, transform.position.z + 1);
                        fruit.GetComponent<Rigidbody2D>().gravityScale = 20;
                    }

                    else

                    {
                        fruit.GetComponent<Rigidbody2D>().gravityScale = 20;

                    }
                }
                else
                {
                    fruit.transform.position = new Vector3(transform.position.x, transform.position.y + 8f, transform.position.z + 1);
                    fruit.GetComponent<Rigidbody2D>().gravityScale = 20;

                }
                onMove = false;
                PlayerPrefs.SetInt("onMove", onMove ? 1 : 0);
                PlayerPrefs.SetString("collidername", null);
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

}
