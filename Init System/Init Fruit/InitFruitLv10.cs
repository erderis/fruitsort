using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitFruitLv10 : MonoBehaviour
{
    public GameObject fruitsOrange;
    public GameObject fruitsCherry;
    public GameObject fruitsBanana;
    public GameObject fruitsApple;
    public GameObject fruitsMelon;
    public GameObject fruitsStrawberry;
    public GameObject fruitsEggplant;

    public List<GameObject> fruits;


    GameObject orange1;
    GameObject orange2;
    GameObject orange3;
    GameObject orange4;

    GameObject cherry1;
    GameObject cherry2;
    GameObject cherry3;
    GameObject cherry4;
    GameObject banana1;
    GameObject banana2;
    GameObject banana3;
    GameObject banana4;

    GameObject apple1;
    GameObject apple2;
    GameObject apple3;
    GameObject apple4;

    GameObject melon1;
    GameObject melon2;
    GameObject melon3;
    GameObject melon4;


    GameObject strawberry1;
    GameObject strawberry2;
    GameObject strawberry3;
    GameObject strawberry4;


    GameObject eggplant1;
    GameObject eggplant2;
    GameObject eggplant3;
    GameObject eggplant4;

    void Start()
    {
        fruits = new List<GameObject>();

        InstantiateOrange();
        InstantiateCherry();
        InstantiateBanana();
        InstantiateMelon();
        InstantiateApple();
        InstantiateStrawberry();
        InstantiateEggplant();

        fruits.Add(apple1);
        fruits.Add(apple2);
        fruits.Add(apple3);
        fruits.Add(banana1);
        fruits.Add(banana2);
        fruits.Add(banana3);
        fruits.Add(cherry1);
        fruits.Add(cherry2);
        fruits.Add(orange1);
        fruits.Add(orange2);
        fruits.Add(orange3);
        fruits.Add(melon1);
        fruits.Add(melon2);
        fruits.Add(melon3);
        fruits.Add(melon4);
        fruits.Add(strawberry1);
        fruits.Add(strawberry2);
        fruits.Add(eggplant1);
        fruits.Add(eggplant2);
        fruits.Add(eggplant3);
    }

    void InstantiateOrange()
    {
        orange1 = Instantiate(fruitsOrange, new Vector3(-3.5f, 16f, 0), Quaternion.identity);
        orange2 = Instantiate(fruitsOrange, new Vector3(3.5f, 24f, 0), Quaternion.identity);
        orange3 = Instantiate(fruitsOrange, new Vector3(3.5f, 20f, 0), Quaternion.identity);
        orange4 = Instantiate(fruitsOrange, new Vector3(-2f, 8f, 0), Quaternion.identity);
        orange1.name = "orange1";
        orange2.name = "orange2";
        orange3.name = "orange3"; 
        orange4.name = "orange4";

    }

    void InstantiateCherry()
    {
        cherry1 = Instantiate(fruitsCherry, new Vector3(-3.5f, 28f, 0), Quaternion.identity);
        cherry2 = Instantiate(fruitsCherry, new Vector3(7f, 28f, 0), Quaternion.identity);
        cherry3 = Instantiate(fruitsCherry, new Vector3(-6f, 4f, 0), Quaternion.identity);
        cherry4 = Instantiate(fruitsCherry, new Vector3(-2f, 0, 0), Quaternion.identity);
        cherry1.name = "cherry1";
        cherry2.name = "cherry2";
        cherry3.name = "cherry3";
        cherry4.name = "cherry4";

    }

    void InstantiateBanana()
    {
        banana1 = Instantiate(fruitsBanana, new Vector3(-7f, 28f, 0), Quaternion.identity);
        banana2 = Instantiate(fruitsBanana, new Vector3(-7f, 20f, 0), Quaternion.identity);
        banana3 = Instantiate(fruitsBanana, new Vector3(0, 16f, 0), Quaternion.identity);
        banana4 = Instantiate(fruitsBanana, new Vector3(-6f, 0, 0), Quaternion.identity);
        banana1.name = "banana1";
        banana2.name = "banana2";
        banana3.name = "banana3";
        banana4.name = "banana4";
    }

    void InstantiateApple()
    {
        apple1 = Instantiate(fruitsApple, new Vector3(-7f, 16f, 0), Quaternion.identity);
        apple2 = Instantiate(fruitsApple, new Vector3(-3.5f, 24f, 0), Quaternion.identity);
        apple3 = Instantiate(fruitsApple, new Vector3(3.5f, 16f, 0), Quaternion.identity);
        apple4 = Instantiate(fruitsApple, new Vector3(-2f, 5f, 0), Quaternion.identity);
        apple1.name = "apple1";
        apple2.name = "apple2";
        apple3.name = "apple3";
        apple4.name = "apple4";
    }

    void InstantiateMelon()
    {
        melon1 = Instantiate(fruitsMelon, new Vector3(-7f, 24f, 0), Quaternion.identity);
        melon2 = Instantiate(fruitsMelon, new Vector3(0, 28f, 0), Quaternion.identity);
        melon3 = Instantiate(fruitsMelon, new Vector3(3.5f, 28f, 0), Quaternion.identity);
        melon4 = Instantiate(fruitsMelon, new Vector3(7f, 24, 0), Quaternion.identity);
        melon1.name = "melon1";
        melon2.name = "melon2";
        melon3.name = "melon3";
        melon4.name = "melon4";
    }
    void InstantiateStrawberry()
    {
        strawberry1 = Instantiate(fruitsStrawberry, new Vector3(0, 24f, 0), Quaternion.identity);
        strawberry2 = Instantiate(fruitsStrawberry, new Vector3(0, 20f, 0), Quaternion.identity);
        strawberry3 = Instantiate(fruitsStrawberry, new Vector3(-6, 12f, 0), Quaternion.identity);
        strawberry4 = Instantiate(fruitsStrawberry, new Vector3(-6f, 8f, 0), Quaternion.identity);
        strawberry1.name = "strawberry1";
        strawberry2.name = "strawberry2";
        strawberry3.name = "strawberry3";
        strawberry4.name = "strawberry4";
    }

    void InstantiateEggplant()
    {
        eggplant1 = Instantiate(fruitsEggplant, new Vector3(-3.5f, 20f, 0), Quaternion.identity);
        eggplant2 = Instantiate(fruitsEggplant, new Vector3(7f, 20f, 0), Quaternion.identity);
        eggplant3 = Instantiate(fruitsEggplant, new Vector3(7f, 16f, 0), Quaternion.identity);
        eggplant4 = Instantiate(fruitsEggplant, new Vector3(-2f, 12f, 0), Quaternion.identity);
        eggplant1.name = "eggplant1";
        eggplant2.name = "eggplant2";
        eggplant3.name = "eggplant3";
        eggplant4.name = "eggplant4";
    }


}
