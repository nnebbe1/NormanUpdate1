using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    // Variables of the sound manager class
    // Soundsources and Soundclips get initialized
    [SerializeField]
    private AudioSource clipsSource;
    [SerializeField]
    private AudioSource backgroundSource;

    [SerializeField]
    private AudioClip damageClip;

    [SerializeField]
    private AudioClip collectClip;

    [SerializeField]
    private AudioClip jumpClip;
    [SerializeField]
    private AudioClip winningClip;

    [SerializeField]
    private AudioClip rainClip;

    [SerializeField]
    private AudioClip backgroundClip;

    [SerializeField]
    private AudioClip gameoverClip;


    void Start()
    {
        //Plays the default background sound
        backgroundSource.clip = backgroundClip;
        backgroundSource.loop = true;
        backgroundSource.Play();

    }

    //Can be called from anywhere to play the needed sound snipped
    public void playSound(string clipName)
    {

        if (clipName == "jump")
        {
            clipsSource.PlayOneShot(jumpClip);
        }
        else if (clipName == "damage")
        {
            clipsSource.PlayOneShot(damageClip);
        }
        else if (clipName == "collect")
        {
            clipsSource.PlayOneShot(collectClip);
        }
        else if (clipName == "gameover")
        {
            clipsSource.clip = gameoverClip;
            clipsSource.Play();
        }
        else if (clipName == "rain")
        {
            backgroundSource.clip = rainClip;
            backgroundSource.loop = true;
            backgroundSource.Play();
        }
        else if (clipName == "background")
        {
            backgroundSource.clip = backgroundClip;
            backgroundSource.loop = true;
            backgroundSource.Play();
        }else if (clipName == "winning")
        {
            clipsSource.clip = winningClip;
            clipsSource.Play();
        }

    }
}