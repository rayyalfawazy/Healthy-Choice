using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TMP_Text icon;
    [SerializeField] Button startButton;
    [SerializeField] TMP_Text version;
    [SerializeField] Slider BGM_Slider, SFX_Slider;
    [SerializeField] AudioMixer audioMixer;

    private void Start()
    {
        StartUpLogoAppear(); // Animate Logo Appear
        LogoLoopMovement(); // Animate Logo Idle
        AnimateStartButton(); // Animate Play Button Idle
        version.text = $"Version {Application.version}"; // Show Game Version

        //Player Pref Loader
        BGM_Slider.value = PlayerPrefs.GetFloat("BGM_Volume");
        SFX_Slider.value = PlayerPrefs.GetFloat("SFX_Volume");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void fullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetBGMVolume()
    {
        float BGMVolume = Mathf.Log10(BGM_Slider.value) * 20;
        audioMixer.SetFloat("BGM_Volume_Mixer", BGMVolume);
        PlayerPrefs.SetFloat("BGM_Volume", BGM_Slider.value);
    }

    public void SetSFXVolume()
    {
        float SFXVolume = Mathf.Log10(SFX_Slider.value) * 20;
        audioMixer.SetFloat("SFX_Volume_Mixer", SFXVolume);
        PlayerPrefs.SetFloat("SFX_Volume", SFX_Slider.value);
    }

    private void AnimateStartButton()
    {
        startButton.transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), 1f)
            .SetLoops(-2, LoopType.Yoyo)
            .SetEase(Ease.OutSine);
    }

    private void StartUpLogoAppear()
    {
        icon.transform.localScale = Vector3.zero;
        icon.transform.DOScale(Vector3.one, 1)
            .SetEase(Ease.InOutExpo);
    }

    private void LogoLoopMovement()
    {
        icon.rectTransform.DOAnchorPos(new Vector2(0, 270f), 1.5f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.OutSine);
    }
}
