using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitFruitLv89 : MonoBehaviour
{
    
    public GameObject fruitsOrange;
    public GameObject fruitsCherry;
    public GameObject fruitsBanana;
    public GameObject fruitsApple;
    public GameObject fruitsMelon;
    public GameObject fruitsStrawberry;
    public GameObject fruitsEggplant;
    public GameObject fruitsPumpkin;
    public GameObject fruitsGrape;

    public List<GameObject> fruits;

    Vector3 pos1a = new Vector3(-7.5f, 28, 0);
    Vector3 pos2a = new Vector3(-7.5f, 24, 0);
    Vector3 pos3a = new Vector3(-7.5f, 20, 0);
    Vector3 pos4a = new Vector3(-7.5f, 16, 0);

    Vector3 pos1b = new Vector3(-4.5f, 28, 0);
    Vector3 pos2b = new Vector3(-4.5f, 24, 0);
    Vector3 pos3b = new Vector3(-4.5f, 20, 0);
    Vector3 pos4b = new Vector3(-4.5f, 16, 0);

    Vector3 pos1c = new Vector3(-1.5f, 28, 0);
    Vector3 pos2c = new Vector3(-1.5f, 24, 0);
    Vector3 pos3c = new Vector3(-1.5f, 20, 0);
    Vector3 pos4c = new Vector3(-1.5f, 16, 0);

    Vector3 pos1d = new Vector3(1.5f, 28, 0);
    Vector3 pos2d = new Vector3(1.5f, 24, 0);
    Vector3 pos3d = new Vector3(1.5f, 20, 0);
    Vector3 pos4d = new Vector3(1.5f, 16, 0);

    Vector3 pos1e = new Vector3(4.5f, 28, 0);
    Vector3 pos2e = new Vector3(4.5f, 24, 0);
    Vector3 pos3e = new Vector3(4.5f, 20, 0);
    Vector3 pos4e = new Vector3(4.5f, 16, 0);

    Vector3 pos1f = new Vector3(7.5f, 28, 0);
    Vector3 pos2f = new Vector3(7.5f, 24, 0);
    Vector3 pos3f = new Vector3(7.5f, 20, 0);
    Vector3 pos4f = new Vector3(7.5f, 16, 0);

    Vector3 pos1g = new Vector3(-7, 12, 0);
    Vector3 pos2g = new Vector3(-7, 8, 0);
    Vector3 pos3g = new Vector3(-7, 4, 0);
    Vector3 pos4g = new Vector3(-7, 0, 0);

    Vector3 pos1h = new Vector3(-3.5f, 12, 0);
    Vector3 pos2h = new Vector3(-3.5f, 8, 0);
    Vector3 pos3h = new Vector3(-3.5f, 5, 0);
    Vector3 pos4h = new Vector3(-3.5f, 0, 0);

    Vector3 pos1i = new Vector3(0, 12, 0);
    Vector3 pos2i = new Vector3(0, 8, 0);
    Vector3 pos3i = new Vector3(0, 5, 0);
    Vector3 pos4i = new Vector3(0, 0, 0);


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

    GameObject pumpkin1;
    GameObject pumpkin2;
    GameObject pumpkin3;
    GameObject pumpkin4;

    GameObject grape1;
    GameObject grape2;
    GameObject grape3;
    GameObject grape4;

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
        InstantiatePumpkin();
        InstantiateGrape();

        fruits.Add(apple1);
        fruits.Add(apple2);
        fruits.Add(apple3);
        fruits.Add(banana1);
        fruits.Add(banana2);
        fruits.Add(banana3);
        fruits.Add(cherry1);
        fruits.Add(orange1);
        fruits.Add(orange2);
        fruits.Add(orange3);
        fruits.Add(melon1);
        fruits.Add(melon2);
        fruits.Add(strawberry1);
        fruits.Add(strawberry2);
        fruits.Add(strawberry3);
        fruits.Add(eggplant1);
        fruits.Add(eggplant2);
        fruits.Add(pumpkin1);
        fruits.Add(pumpkin2);
        fruits.Add(pumpkin3);
        fruits.Add(pumpkin4);
        fruits.Add(grape1);
        fruits.Add(grape2);
        fruits.Add(grape3);
    }

    void InstantiateOrange()
    {
        orange1 = Instantiate(fruitsOrange, pos3a, Quaternion.identity);
        orange2 = Instantiate(fruitsOrange, pos4a, Quaternion.identity);
        orange3 = Instantiate(fruitsOrange, pos2e, Quaternion.identity);
        orange4 = Instantiate(fruitsOrange, pos2g, Quaternion.identity);
        orange1.name = "orange1";
        orange2.name = "orange2";
        orange3.name = "orange3";
        orange4.name = "orange4";

    }

    void InstantiateCherry()
    {
        cherry1 = Instantiate(fruitsCherry, pos4d, Quaternion.identity);
        cherry2 = Instantiate(fruitsCherry, pos2h, Quaternion.identity);
        cherry3 = Instantiate(fruitsCherry, pos1i, Quaternion.identity);
        cherry4 = Instantiate(fruitsCherry, pos2i, Quaternion.identity);
        cherry1.name = "cherry1";
        cherry2.name = "cherry2";
        cherry3.name = "cherry3";
        cherry4.name = "cherry4";

    }

    void InstantiateBanana()
    {
        banana1 = Instantiate(fruitsBanana, pos3b, Quaternion.identity);
        banana2 = Instantiate(fruitsBanana, pos1e, Quaternion.identity);
        banana3 = Instantiate(fruitsBanana, pos3f, Quaternion.identity);
        banana4 = Instantiate(fruitsBanana, pos1g, Quaternion.identity);
        banana1.name = "banana1";
        banana2.name = "banana2";
        banana3.name = "banana3";
        banana4.name = "banana4";
    }

    void InstantiateApple()
    {
        apple1 = Instantiate(fruitsApple, pos1a, Quaternion.identity);
        apple2 = Instantiate(fruitsApple, pos1c, Quaternion.identity);
        apple3 = Instantiate(fruitsApple, pos2f, Quaternion.identity);
        apple4 = Instantiate(fruitsApple, pos3h, Quaternion.identity);
        apple1.name = "apple1";
        apple2.name = "apple2";
        apple3.name = "apple3";
        apple4.name = "apple4";
    }

    void InstantiateMelon()
    {
        melon1 = Instantiate(fruitsMelon, pos1d, Quaternion.identity);
        melon2 = Instantiate(fruitsMelon, pos3d, Quaternion.identity);
        melon3 = Instantiate(fruitsMelon, pos3g, Quaternion.identity);
        melon4 = Instantiate(fruitsMelon, pos1h, Quaternion.identity);
        melon1.name = "melon1";
        melon2.name = "melon2";
        melon3.name = "melon3";
        melon4.name = "melon4";
    }
    void InstantiateStrawberry()
    {
        strawberry1 = Instantiate(fruitsStrawberry, pos4c, Quaternion.identity);
        strawberry2 = Instantiate(fruitsStrawberry, pos2d, Quaternion.identity);
        strawberry3 = Instantiate(fruitsStrawberry, pos1f, Quaternion.identity);
        strawberry4 = Instantiate(fruitsStrawberry, pos3i, Quaternion.identity);
        strawberry1.name = "strawberry1";
        strawberry2.name = "strawberry2";
        strawberry3.name = "strawberry3";
        strawberry4.name = "strawberry4";
    }

    void InstantiateEggplant()
    {
        eggplant1 = Instantiate(fruitsEggplant, pos2b, Quaternion.identity);
        eggplant2 = Instantiate(fruitsEggplant, pos3c, Quaternion.identity);
        eggplant3 = Instantiate(fruitsEggplant, pos4g, Quaternion.identity);
        eggplant4 = Instantiate(fruitsEggplant, pos4i, Quaternion.identity);
        eggplant1.name = "eggplant1";
        eggplant2.name = "eggplant2";
        eggplant3.name = "eggplant3";
        eggplant4.name = "eggplant4";
    }

    void InstantiatePumpkin()
    {
        pumpkin1 = Instantiate(fruitsPumpkin, pos2a, Quaternion.identity);
        pumpkin2 = Instantiate(fruitsPumpkin, pos1b, Quaternion.identity);
        pumpkin3 = Instantiate(fruitsPumpkin, pos2c, Quaternion.identity);
        pumpkin4 = Instantiate(fruitsPumpkin, pos4f, Quaternion.identity);
        pumpkin1.name = "pumpkin1";
        pumpkin2.name = "pumpkin2";
        pumpkin3.name = "pumpkin3";
        pumpkin4.name = "pumpkin4";
    }

    void InstantiateGrape()
    {
        grape1 = Instantiate(fruitsGrape, pos4b, Quaternion.identity);
        grape2 = Instantiate(fruitsGrape, pos3e, Quaternion.identity);
        grape3 = Instantiate(fruitsGrape, pos4e, Quaternion.identity);
        grape4 = Instantiate(fruitsGrape, pos4h, Quaternion.identity);
        grape1.name = "grape1";
        grape2.name = "grape2";
        grape3.name = "grape3";
        grape4.name = "grape4";
    }

}
