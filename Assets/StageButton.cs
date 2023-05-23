using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageButton : MonoBehaviour
{
    public int level;
    public TextMeshProUGUI text;

    private void Start()
    {
        text.text = $"Stage {level + 1}";
    }

    public void LoadStage()
    {
        SceneManager.LoadScene("Gameplay");
        PlayerPrefs.SetInt("LevelData", level);
    }
}
