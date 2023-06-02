using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    [SerializeField] Catcher catcher;
    [SerializeField] UnityEvent onWin, onLose, preStart, onEndStage;

    public int spawnDelay;
    public int targetScore;
    public float baseMinFall, baseMaxFall;
    public List<StageData> stageDatas;
    public StageData currentStage;
    [System.NonSerialized] public int value;

    private void Start()
    {
        GetStageData();
        PreStart();
    }

    void Update()
    {
        value = catcher.GetScore();
        if (value == targetScore)
        {
            // Win Statement
            onWin.Invoke();
        }

        if (value == -targetScore)
        {
            // Lose Statement
            onLose.Invoke();
        }
    }

    public void GoToNextStage()
    {
            int nextIndex = PlayerPrefs.GetInt("LevelData") + 1;
            PlayerPrefs.SetInt("LevelData", nextIndex);
            GetStageData();
            PreStart();
    }

    public void GetStageData()
    {
        try
        {
            int tmpIndex = PlayerPrefs.GetInt("LevelData");
            currentStage = stageDatas[tmpIndex];
            spawnDelay = currentStage.spawnDelay;
            targetScore = currentStage.targetObjective;
            baseMinFall = currentStage.minFallSpeedValue;
            baseMaxFall = currentStage.maxFalSpeedValue;
        }
        catch
        {
            onEndStage.Invoke();
            // SceneManager.LoadScene("LevelSelector");
            DOTween.KillAll();
        }
    }

    public void PreStart()
    {
        preStart.Invoke();
    }
}
