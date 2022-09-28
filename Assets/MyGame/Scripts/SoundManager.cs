using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource myFx;
    public AudioClip plusFx;
    public AudioClip clickFx;

    public void SoundPlus()
    {
        myFx.PlayOneShot(plusFx);
    }
    public void SoundMinus()
    {
        myFx.PlayOneShot(clickFx);
    }
}