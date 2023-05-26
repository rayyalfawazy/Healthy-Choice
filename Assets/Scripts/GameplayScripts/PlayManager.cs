using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PlayManager : MonoBehaviour
{
    [SerializeField] Catcher catcher;
    [SerializeField] UnityEvent onWin, onLose, preStart;
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
        int nextIndex = PlayerPrefs.GetInt("LevelData") + 1;
        PlayerPrefs.SetInt("LevelData", nextIndex);
        // Debug.Log($"Player Pref : {PlayerPrefs.GetInt("LevelData")}, Next Index : {nextIndex}");
        GetStageData();
        PreStart();
    }

    public void GetStageData()
    {
        int tmpIndex = PlayerPrefs.GetInt("LevelData");
        currentStage = stageDatas[tmpIndex];
        targetScore = currentStage.targetObjective;
        baseMinFall = currentStage.minFallSpeedValue;
        baseMaxFall = currentStage.maxFalSpeedValue;

        Debug.Log($"Player Pref Index : {tmpIndex}, Data : {targetScore} {baseMinFall} {baseMaxFall}");
    }

    public void PreStart()
    {
        preStart.Invoke();
        Debug.Log($"Kamu harus mengumpulkan {targetScore} poin Healthy jika ingin menang, namun jika kamu mengumpulkan {targetScore} poin Unhealthy kamu akan kalah");
    }
}
