using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class SoundManger : MonoBehaviour
{
    AudioSource audio;
    public AudioClip getItem;
    public AudioClip jump;
    public AudioClip land;
    public AudioClip obstacle;
    public AudioClip BGM;
    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    void Start()
    {
        audio.clip = BGM;
        audio.Play();
    }

    void Update()
    {
        
    }
    public void Play(string a)
    {
        switch (a)
        {
            case "jumping":
                audio.clip = jump;
                audio.Play(); 
                break;
            case "getitem":
                audio.clip = getItem;
                audio.Play(); 
                break;
            case "landing":
                audio.clip = land;
                audio.Play(); 
                break;
            case "Obs":
                audio.clip = obstacle;
                audio.Play();
                break;
        }
    }
}
