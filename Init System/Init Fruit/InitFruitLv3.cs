using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitFruitLv3 : MonoBehaviour
{
    public GameObject fruitsOrange;
    public GameObject fruitsCherry;
    public GameObject fruitsBanana;

    void Start()
    {
        InstantiateOrange();
        InstantiateCherry();
        InstantiateBanana();
    }

    void InstantiateOrange()
    {
        GameObject orange1 = Instantiate(fruitsOrange, new Vector3(-7.41f, 8f, 0), Quaternion.identity);
        GameObject orange2 = Instantiate(fruitsOrange, new Vector3(-3.77f, 8f, 0), Quaternion.identity);
        GameObject orange3 = Instantiate(fruitsOrange, new Vector3(-3.77f, 4f, 0), Quaternion.identity);
        GameObject orange4 = Instantiate(fruitsOrange, new Vector3(0, 12f, 0), Quaternion.identity);
        orange1.name = "orange1";
        orange2.name = "orange2";
        orange3.name = "orange3"; 
        orange4.name = "orange4";

    }

    void InstantiateCherry()
    {
        GameObject cherry1 = Instantiate(fruitsCherry, new Vector3(-7.41f, 12f, 0), Quaternion.identity);
        GameObject cherry2 = Instantiate(fruitsCherry, new Vector3(-3.77f, 12f, 0), Quaternion.identity);
        GameObject cherry3 = Instantiate(fruitsCherry, new Vector3(0f, 16f, 0), Quaternion.identity);
        GameObject cherry4 = Instantiate(fruitsCherry, new Vector3(0, 4f, 0), Quaternion.identity);
        cherry1.name = "cherry1";
        cherry2.name = "cherry2";
        cherry3.name = "cherry3";
        cherry4.name = "cherry4";

    }

    void InstantiateBanana()
    {
        GameObject banana1 = Instantiate(fruitsBanana, new Vector3(-7.41f, 16f, 0), Quaternion.identity);
        GameObject banana2 = Instantiate(fruitsBanana, new Vector3(-7.41f, 4f, 0), Quaternion.identity);
        GameObject banana3 = Instantiate(fruitsBanana, new Vector3(-3.77f, 16f, 0), Quaternion.identity);
        GameObject banana4 = Instantiate(fruitsBanana, new Vector3(0, 8f, 0), Quaternion.identity);
        banana1.name = "banana1";
        banana2.name = "banana2";
        banana3.name = "banana3";
        banana4.name = "banana4";
    }

}
