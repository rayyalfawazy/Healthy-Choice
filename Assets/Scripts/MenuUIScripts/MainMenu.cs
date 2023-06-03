using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TMP_Text icon;
    [SerializeField] Button startButton;
    [SerializeField] TMP_Text version;

    private void Start()
    {
        StartUpLogoAppear();
        AnimateStartButton(); // Animate Play Button
        version.text = $"Version {Application.version}"; // Show Game Version
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void fullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    private void AnimateStartButton()
    {
        startButton.transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), 0.5f)
            .SetLoops(-2, LoopType.Yoyo)
            .SetEase(Ease.OutSine);
    }

    private void StartUpLogoAppear()
    {
        icon.transform.localScale = Vector3.zero;
        icon.transform.DOScale(Vector3.one, 3)
            .SetEase(Ease.InOutExpo);
    }
}
