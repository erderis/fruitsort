using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitFruitLv141 : MonoBehaviour
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
    public GameObject fruitsBlackBerry;
    public GameObject fruitsBlueBerry;
    public GameObject fruitsManggoes;

    public List<GameObject> fruits;

    Vector3 pos1a = new Vector3(-7.8f, 28, 0);
    Vector3 pos2a = new Vector3(-7.8f, 24, 0);
    Vector3 pos3a = new Vector3(-7.8f, 20, 0);
    Vector3 pos4a = new Vector3(-7.8f, 16, 0);

    Vector3 pos1b = new Vector3(-5.2f, 28, 0);
    Vector3 pos2b = new Vector3(-5.2f, 24, 0);
    Vector3 pos3b = new Vector3(-5.2f, 20, 0);
    Vector3 pos4b = new Vector3(-5.2f, 16, 0);

    Vector3 pos1c = new Vector3(-2.6f, 28, 0);
    Vector3 pos2c = new Vector3(-2.6f, 24, 0);
    Vector3 pos3c = new Vector3(-2.6f, 20, 0);
    Vector3 pos4c = new Vector3(-2.6f, 16, 0);

    Vector3 pos1d = new Vector3(0, 28, 0);
    Vector3 pos2d = new Vector3(0, 24, 0);
    Vector3 pos3d = new Vector3(0, 20, 0);
    Vector3 pos4d = new Vector3(0, 16, 0);

    Vector3 pos1e = new Vector3(2.6f, 28, 0);
    Vector3 pos2e = new Vector3(2.6f, 24, 0);
    Vector3 pos3e = new Vector3(2.6f, 20, 0);
    Vector3 pos4e = new Vector3(2.6f, 16, 0);

    Vector3 pos1f = new Vector3(5.2f, 28, 0);
    Vector3 pos2f = new Vector3(5.2f, 24, 0);
    Vector3 pos3f = new Vector3(5.2f, 20, 0);
    Vector3 pos4f = new Vector3(5.2f, 16, 0);

    Vector3 pos1g = new Vector3(7.8f, 28, 0);
    Vector3 pos2g = new Vector3(7.8f, 24, 0);
    Vector3 pos3g = new Vector3(7.8f, 20, 0);
    Vector3 pos4g = new Vector3(7.8f, 16, 0);

    Vector3 pos1h = new Vector3(-7.8f, 12, 0);
    Vector3 pos2h = new Vector3(-7.8f, 8, 0);
    Vector3 pos3h = new Vector3(-7.8f, 4, 0);
    Vector3 pos4h = new Vector3(-7.8f, 0, 0);

    Vector3 pos1i = new Vector3(-5.2f, 12, 0);
    Vector3 pos2i = new Vector3(-5.2f, 8, 0);
    Vector3 pos3i = new Vector3(-5.2f, 4, 0);
    Vector3 pos4i = new Vector3(-5.2f, 0, 0);

    Vector3 pos1j = new Vector3(-2.6f, 12, 0);
    Vector3 pos2j = new Vector3(-2.6f, 8, 0);
    Vector3 pos3j = new Vector3(-2.6f, 4, 0);
    Vector3 pos4j = new Vector3(-2.6f, 0, 0);

    Vector3 pos1k = new Vector3(0, 12, 0);
    Vector3 pos2k = new Vector3(0, 8, 0);
    Vector3 pos3k = new Vector3(0, 4, 0);
    Vector3 pos4k = new Vector3(0, 0, 0);

    Vector3 pos1l = new Vector3(2.6f, 12, 0);
    Vector3 pos2l = new Vector3(2.6f, 8, 0);
    Vector3 pos3l = new Vector3(2.6f, 4, 0);
    Vector3 pos4l = new Vector3(2.6f, 0, 0);



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

    GameObject blackberry1;
    GameObject blackberry2;
    GameObject blackberry3;
    GameObject blackberry4;

    GameObject blueberry1;
    GameObject blueberry2;
    GameObject blueberry3;
    GameObject blueberry4;

    GameObject manggoes1;
    GameObject manggoes2;
    GameObject manggoes3;
    GameObject manggoes4;

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
        InstantiateBlackBerry();
        InstantiateBlueBerry();
        InstantiateManggoes();

        fruits.Add(apple1);
        fruits.Add(apple2);
        fruits.Add(banana1);
        fruits.Add(banana2);
        fruits.Add(banana3);
        fruits.Add(banana4);
        fruits.Add(cherry1);
        fruits.Add(cherry2);
        fruits.Add(orange1);
        fruits.Add(orange2);
        fruits.Add(orange3);
        fruits.Add(orange4);
        fruits.Add(melon1);
        fruits.Add(strawberry1);
        fruits.Add(strawberry2);
        fruits.Add(strawberry3);
        fruits.Add(eggplant1);
        fruits.Add(pumpkin1);
        fruits.Add(grape1);
        fruits.Add(grape2);
        fruits.Add(blackberry1);
        fruits.Add(blackberry2);
        fruits.Add(blackberry3);
        fruits.Add(blueberry1);
        fruits.Add(blueberry2);
        fruits.Add(manggoes1);
        fruits.Add(manggoes2);
        fruits.Add(manggoes3);
    }

    void InstantiateOrange()
    {
        orange1 = Instantiate(fruitsOrange, pos4a, Quaternion.identity); //orange
        orange2 = Instantiate(fruitsOrange, pos1b, Quaternion.identity);
        orange3 = Instantiate(fruitsOrange, pos2b, Quaternion.identity);
        orange4 = Instantiate(fruitsOrange, pos2c, Quaternion.identity);
        orange1.name = "orange1";
        orange2.name = "orange2";
        orange3.name = "orange3";
        orange4.name = "orange4";

    }

    void InstantiateCherry()
    {
        cherry1 = Instantiate(fruitsCherry, pos3c, Quaternion.identity); //merah
        cherry2 = Instantiate(fruitsCherry, pos1f, Quaternion.identity);
        cherry3 = Instantiate(fruitsCherry, pos3i, Quaternion.identity);
        cherry4 = Instantiate(fruitsCherry, pos4j, Quaternion.identity);
        cherry1.name = "cherry1";
        cherry2.name = "cherry2";
        cherry3.name = "cherry3";
        cherry4.name = "cherry4";

    }

    void InstantiateBanana()
    {
        banana1 = Instantiate(fruitsBanana, pos3d, Quaternion.identity); //biru
        banana2 = Instantiate(fruitsBanana, pos4e, Quaternion.identity);
        banana3 = Instantiate(fruitsBanana, pos2f, Quaternion.identity);
        banana4 = Instantiate(fruitsBanana, pos3g, Quaternion.identity);
        banana1.name = "banana1";
        banana2.name = "banana2";
        banana3.name = "banana3";
        banana4.name = "banana4";
    }

    void InstantiateApple()
    {
        apple1 = Instantiate(fruitsApple, pos3b, Quaternion.identity); //pink
        apple2 = Instantiate(fruitsApple, pos3f, Quaternion.identity);
        apple3 = Instantiate(fruitsApple, pos2h, Quaternion.identity);
        apple4 = Instantiate(fruitsApple, pos1i, Quaternion.identity);
        apple1.name = "apple1";
        apple2.name = "apple2";
        apple3.name = "apple3";
        apple4.name = "apple4";
    }

    void InstantiateMelon()
    {
        melon1 = Instantiate(fruitsMelon, pos1a, Quaternion.identity); //hijau
        melon2 = Instantiate(fruitsMelon, pos2j, Quaternion.identity);
        melon3 = Instantiate(fruitsMelon, pos4k, Quaternion.identity);
        melon4 = Instantiate(fruitsMelon, pos1l, Quaternion.identity);
        melon1.name = "melon1";
        melon2.name = "melon2";
        melon3.name = "melon3";
        melon4.name = "melon4";
    }
    void InstantiateStrawberry()
    {
        strawberry1 = Instantiate(fruitsStrawberry, pos3a, Quaternion.identity); //biru muda
        strawberry2 = Instantiate(fruitsStrawberry, pos4d, Quaternion.identity);
        strawberry3 = Instantiate(fruitsStrawberry, pos1g, Quaternion.identity);
        strawberry4 = Instantiate(fruitsStrawberry, pos4h, Quaternion.identity);
        strawberry1.name = "strawberry1";
        strawberry2.name = "strawberry2";
        strawberry3.name = "strawberry3";
        strawberry4.name = "strawberry4";
    }

    void InstantiateEggplant()
    {
        eggplant1 = Instantiate(fruitsEggplant, pos2a, Quaternion.identity); //abu
        eggplant2 = Instantiate(fruitsEggplant, pos3h, Quaternion.identity);
        eggplant3 = Instantiate(fruitsEggplant, pos1k, Quaternion.identity);
        eggplant4 = Instantiate(fruitsEggplant, pos2k, Quaternion.identity);
        eggplant1.name = "eggplant1";
        eggplant2.name = "eggplant2";
        eggplant3.name = "eggplant3";
        eggplant4.name = "eggplant4";
    }

    void InstantiatePumpkin()
    {
        pumpkin1 = Instantiate(fruitsPumpkin, pos4f, Quaternion.identity); //hijau tua
        pumpkin2 = Instantiate(fruitsPumpkin, pos1h, Quaternion.identity);
        pumpkin3 = Instantiate(fruitsPumpkin, pos2i, Quaternion.identity);
        pumpkin4 = Instantiate(fruitsPumpkin, pos3j, Quaternion.identity);
        pumpkin1.name = "pumpkin1";
        pumpkin2.name = "pumpkin2";
        pumpkin3.name = "pumpkin3";
        pumpkin4.name = "pumpkin4";
    }

    void InstantiateGrape()
    {
        grape1 = Instantiate(fruitsGrape, pos1d, Quaternion.identity); //ungu
        grape2 = Instantiate(fruitsGrape, pos2d, Quaternion.identity);
        grape3 = Instantiate(fruitsGrape, pos4i, Quaternion.identity);
        grape4 = Instantiate(fruitsGrape, pos2l, Quaternion.identity);
        grape1.name = "grape1";
        grape2.name = "grape2";
        grape3.name = "grape3";
        grape4.name = "grape4";
    }

    void InstantiateBlackBerry()
    {
        blackberry1 = Instantiate(fruitsBlackBerry, pos3e, Quaternion.identity); //coklat
        blackberry2 = Instantiate(fruitsBlackBerry, pos2g, Quaternion.identity);
        blackberry3 = Instantiate(fruitsBlackBerry, pos4g, Quaternion.identity);
        blackberry4 = Instantiate(fruitsBlackBerry, pos3k, Quaternion.identity);
        blackberry1.name = "blackberry1";
        blackberry2.name = "blackberry2";
        blackberry3.name = "blackberry3";
        blackberry4.name = "blackberry4";
    }

    void InstantiateBlueBerry()
    {
        blueberry1 = Instantiate(fruitsBlueBerry, pos4c, Quaternion.identity); //hijau tua
        blueberry2 = Instantiate(fruitsBlueBerry, pos2e, Quaternion.identity);
        blueberry3 = Instantiate(fruitsBlueBerry, pos3l, Quaternion.identity);
        blueberry4 = Instantiate(fruitsBlueBerry, pos4l, Quaternion.identity);
        blueberry1.name = "blueberry1";
        blueberry2.name = "blueberry2";
        blueberry3.name = "blueberry3";
        blueberry4.name = "blueberry4";
    }

    void InstantiateManggoes()
    {
        manggoes1 = Instantiate(fruitsManggoes, pos4b, Quaternion.identity); //kuning
        manggoes2 = Instantiate(fruitsManggoes, pos1c, Quaternion.identity);
        manggoes3 = Instantiate(fruitsManggoes, pos1e, Quaternion.identity);
        manggoes4 = Instantiate(fruitsManggoes, pos1j, Quaternion.identity);
        manggoes1.name = "manggoes1";
        manggoes2.name = "manggoes2";
        manggoes3.name = "manggoes3";
        manggoes4.name = "manggoes4";
    }

}
