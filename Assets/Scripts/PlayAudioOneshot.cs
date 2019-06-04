using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOneshot : MonoBehaviour
{
    AudioSource Source;
    AudioClip Soundbyte;
    // Start is called before the first frame update
    void Start()
    {
        Source = gameObject.GetComponent<AudioSource>();
        Soundbyte = Source.clip;
    }

    public void PlayAudioClip()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(Soundbyte);
    }
}
