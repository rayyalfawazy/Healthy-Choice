using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class MainMenu : MonoBehaviour
{
    private Button button;
    private void Start()
    {
        button = GetComponent<Button>();
        transform.localScale = Vector3.one;
        transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), 0.5f)
            .SetLoops(-2, LoopType.Yoyo)
            .SetEase(Ease.OutSine);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("LevelSelector");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void fullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen; 
    }
}
