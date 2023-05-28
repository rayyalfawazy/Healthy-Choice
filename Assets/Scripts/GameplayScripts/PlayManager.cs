using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayManager : MonoBehaviour
{
    [SerializeField] Catcher catcher;
    [SerializeField] UnityEvent onWin, onLose, preStart, onEndStage;
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
        // Debug.Log($"Target Objective : {targetScore}");

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
        try
        {
            int nextIndex = PlayerPrefs.GetInt("LevelData") + 1;
            PlayerPrefs.SetInt("LevelData", nextIndex);
            GetStageData();
            PreStart();
        }
        catch 
        {
            SceneManager.LoadScene("LevelSelector");
            DOTween.KillAll();
            onEndStage.Invoke();
        }
    }

    public void GetStageData()
    {
        int tmpIndex = PlayerPrefs.GetInt("LevelData");
        currentStage = stageDatas[tmpIndex];
        targetScore = currentStage.targetObjective;
        baseMinFall = currentStage.minFallSpeedValue;
        baseMaxFall = currentStage.maxFalSpeedValue;
    }

    public void PreStart()
    {
        preStart.Invoke();
    }
}
