using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageButton : MonoBehaviour
{
    public int level;
    public TextMeshProUGUI text;
    public GameObject loadingScreen;
    public Slider loadingBar;
    bool isStart = false;

    private void Start()
    {
        text.text = $"Stage {level + 1}";
    }

    private void Update()
    {
        if (isStart == true)
        {
            if (loadingBar.value != loadingBar.maxValue)
            {
                loadingBar.value += Time.deltaTime;
            }
            else
            {
                LoadStage();
                loadingScreen.SetActive(false);
                loadingBar.value = loadingBar.minValue;
                isStart = false;
            }
        }
    }

    public void LoadStage()
    {
        SceneManager.LoadScene("Gameplay");
        PlayerPrefs.SetInt("LevelData", level);

    }

    public void ButtonPressLoad()
    {
        isStart = true;
        loadingScreen.SetActive(true);
    }
}
