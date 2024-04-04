using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeManger : MonoBehaviour
{
    [SerializeField] AudioMixer myMixer;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider SFXSlider;
    // Start is called before the first frame update

    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
            LoadVolume();
        else
        {
            SetMusicVolume();
            SetSFXVolume();
        }
    }
    public void SetMusicVolume()
    {
        myMixer.SetFloat("music", musicSlider.value);
        PlayerPrefs.SetFloat("musicVolume", musicSlider.value);
    }

    public void SetSFXVolume()
    {   
        myMixer.SetFloat("SFX", (SFXSlider.value));
        PlayerPrefs.SetFloat("SFXVolume", SFXSlider.value);
    }

    void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        SetMusicVolume();
        SetSFXVolume();
    }
}
