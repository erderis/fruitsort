using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitFruit : MonoBehaviour
{
    public GameObject fruitsOrange;
    public GameObject fruitsCherry;

    void Start()
    {
        InstantiateOrange();
        InstantiateCherry();
    }

    void InstantiateOrange()
    {
        GameObject orange1 = Instantiate(fruitsOrange, new Vector3(-0.08f, 18.47f, 0), Quaternion.identity);
        GameObject orange2 = Instantiate(fruitsOrange, new Vector3(-0.08f, 10.45f, 0), Quaternion.identity);
        GameObject orange3 = Instantiate(fruitsOrange, new Vector3(-6.14f, 14.56f, 0), Quaternion.identity);
        GameObject orange4 = Instantiate(fruitsOrange, new Vector3(-6.14f, 6.49f, 0), Quaternion.identity);
        orange1.name = "orange1";
        orange2.name = "orange2";
        orange3.name = "orange3"; 
        orange4.name = "orange4";

    }

    void InstantiateCherry()
    {
        GameObject cherry1 = Instantiate(fruitsCherry, new Vector3(-6.14f, 18.47f, 0), Quaternion.identity);
        GameObject cherry2 = Instantiate(fruitsCherry, new Vector3(-6.14f, 10.45f, 0), Quaternion.identity);
        GameObject cherry3 = Instantiate(fruitsCherry, new Vector3(-0.08f, 14.56f, 0), Quaternion.identity);
        GameObject cherry4 = Instantiate(fruitsCherry, new Vector3(-0.08f, 6.49f, 0), Quaternion.identity);
        cherry1.name = "cherry1";
        cherry2.name = "cherry2";
        cherry3.name = "cherry3";
        cherry4.name = "cherry4";

    }

}
