using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicClass : MonoBehaviour
{
    private AudioSource _audioSource;

    public AudioClip[] audioClips;

    List<AudioSource> audioSources;



    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();

        audioSources = new List<AudioSource>();

        for (int i = 0; i < 7; i++)
        {

            audioSources.Add(transform.gameObject.AddComponent<AudioSource>());

        }

        string isSoundMuted = PlayerPrefs.GetString("isMusicMuted", "false");
        string isMusicMuted = PlayerPrefs.GetString("isMusicMuted", "false");

        if (isSoundMuted == "false")
        {
            for (int i = 0; i < 7; i++)
            {
                audioSources[i].volume = 1;
            }
        }
        else
        {
            for (int i = 0; i < 7; i++)
            {
                audioSources[i].volume = 0;
            }
        }

        if (isMusicMuted == "false")
        {
            _audioSource.volume = 1;
        }
        else
        {
            _audioSource.volume = 0;
        }
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }

    public void BeforeLostSound()
    {
        audioSources[0].clip = audioClips[0];
        audioSources[0].loop = true;
        audioSources[0].Play();
    }
    public void BeforeLostSoundStop()
    {
        audioSources[0].Stop();
    }

    public void ButtonSound()
    {
        audioSources[1].clip = audioClips[1];
        audioSources[1].Play();

    }
    public void CountDownSoundUnder10()
    {
        audioSources[2].clip = audioClips[2];
        audioSources[2].Play();

    }

    public void CountDownSoundUnder10Stop()
    {
        audioSources[2].Stop();

    }
    public void FruitUpSound()
    {
        audioSources[3].clip = audioClips[3];
        audioSources[3].Play();

    }
    public void GlassFullSound()
    {
        audioSources[4].clip = audioClips[4];
        audioSources[4].Play();

    }
    public void LostSound()
    {
        audioSources[5].clip = audioClips[5];
        audioSources[5].Play();

    }
    public void WinSound()
    {
        audioSources[6].clip = audioClips[6];
        audioSources[6].Play();

    }

    public void MuteMusic()
    {
        _audioSource.volume = 0;
    }

    public void GiveMusic()
    {
        _audioSource.volume = 1;
    }

    public void MuteSound()
    {
        for (int i = 0; i < 7; i++)
        {
            audioSources[i].volume = 0;
        }
    }

    public void GiveSound()
    {
        for (int i = 0; i < 7; i++)
        {
            audioSources[i].volume = 1;
        }
    }
}
