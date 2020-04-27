
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfettiController : MonoBehaviour
{

    public ParticleSystem confetti;
    public ParticleSystem confetti1;
    public ParticleSystem confetti2;
    public ParticleSystem confetti3;
    public ParticleSystem confetti4;
    public ParticleSystem confetti5;
    public ParticleSystem confetti6;


    void Start()
    {

        confetti.Stop();
        confetti1.Stop();
        confetti2.Stop();
        confetti3.Stop();
        confetti4.Stop();
        confetti5.Stop();
        confetti6.Stop();
        InvokeRepeating("startConfetti", 2f, 2f);
        InvokeRepeating("startConfetti1", 0f, 3f);
        InvokeRepeating("startConfetti2", 3f, 2f);
        InvokeRepeating("startConfetti3", 1f, 3f);

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void startConfetti()
    {
        confetti.Play();
        confetti6.Play();
    }

    void startConfetti1()
    {
        confetti1.Play();
        confetti4.Play();
    }
    void startConfetti2()
    {
        confetti5.Play();
        confetti2.Play();
    }
    void startConfetti3()
    {
        confetti5.Play();
        confetti3.Play();
    }

}
