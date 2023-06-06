using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsConfig : MonoBehaviour
{
    [SerializeField] Slider BGM_Slider, SFX_Slider;
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Toggle muteToggle;

    void Start()
    {
        BGM_Slider.value = PlayerPrefs.GetFloat("BGM_Volume");
        SFX_Slider.value = PlayerPrefs.GetFloat("SFX_Volume");
        muteToggle.isOn = PlayerPrefs.GetInt("IsMute") == 1 ? true : false;
    }

    void Update()
    {
        MuteChecker();
    }

    public void SetBGMVolume()
    {
        float BGMVolume = Mathf.Log10(BGM_Slider.value) * 20;
        audioMixer.SetFloat("BGM_Volume_Mixer", BGMVolume);

        if (BGMVolume == -40)
        {
            audioMixer.SetFloat("BGM_Volume_Mixer", -80f);
        }

        PlayerPrefs.SetFloat("BGM_Volume", BGM_Slider.value);
    }

    public void SetSFXVolume()
    {
        float SFXVolume = Mathf.Log10(SFX_Slider.value) * 20;
        audioMixer.SetFloat("SFX_Volume_Mixer", SFXVolume);

        if (SFXVolume == -40)
        {
            audioMixer.SetFloat("SFX_Volume_Mixer", -80f);
        }

        PlayerPrefs.SetFloat("SFX_Volume", SFX_Slider.value);
    }

    public void MuteChecker()
    {
        int isMute = Convert.ToInt32(muteToggle.isOn);
        PlayerPrefs.SetInt("IsMute", isMute);
        if (isMute == 1)
        {
            audioMixer.SetFloat("BGM_Volume_Mixer", -80f);
            audioMixer.SetFloat("SFX_Volume_Mixer", -80f);
        }
        else
        {
            SetSFXVolume();
            SetBGMVolume();
        }
    }
}
