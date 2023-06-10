using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
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
    private AudioClip rainClip;

    [SerializeField]
    private AudioClip backgroundClip;

    void Start()
    {
        backgroundSource.clip = backgroundClip;
        backgroundSource.loop = true;
        backgroundSource.Play();

    }
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
        }

    }
}