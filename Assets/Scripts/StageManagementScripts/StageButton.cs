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

    private void Start()
    {
        text.text = $"{level + 1}";
    }

    public void LoadStage()
    {
        PlayerPrefs.SetInt("LevelData", level);
    }
}
