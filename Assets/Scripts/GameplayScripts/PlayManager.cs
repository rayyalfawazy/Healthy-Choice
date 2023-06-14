using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    public Catcher catcher;
    public UnityEvent onWin, onLose, preStart, onEndStage;

    public int spawnDelay;
    public int targetScore;
    public float baseMinFall, baseMaxFall;
    public Texture2D backgroundImage;
    public List<StageData> stageDatas;
    public StageData currentStage;
    [System.NonSerialized] public int scoreValue, healthValue;

    private void Start()
    {
        GetStageData();
        PreStart();
    }

    void Update()
    {
        scoreValue = catcher.score;
        healthValue = catcher.score;

        if (scoreValue == targetScore)
        {
            // Win Statement
            onWin.Invoke();
        }

        if (healthValue <= 0)
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
            backgroundImage = currentStage.stageBackgroundImage;
        }
        catch
        {
            onEndStage.Invoke();
            DOTween.KillAll();
        }
    }

    public void ResetScore()
    {
        catcher.score = 0;
        catcher.health = 10;
    }

    public void PreStart()
    {
        preStart.Invoke();
    }
}
