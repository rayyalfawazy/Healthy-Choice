using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PlayManager : MonoBehaviour
{
    [SerializeField] Catcher catcher;
    int targetScore;
    [SerializeField] UnityEvent onWin, onLose;

    public List<StageData> stageDatas;
    public StageData currentStage;

    [System.NonSerialized] public int value;

    private void Start()
    {
        int tmpIndex = PlayerPrefs.GetInt("LevelData");
        currentStage = stageDatas[tmpIndex];
        targetScore = currentStage.targetObjective;
    }

    void Update()
    {
        value = catcher.GetScore();
        if (value == targetScore)
        {
            // Win Statement
            // Debug.Log("Win");
            onWin.Invoke();
        }

        if (value == -targetScore)
        {
            // Lose Statement
            // Debug.Log("Lose");
            onLose.Invoke();
        }
    }

    public void GoToNextStage()
    {
        int nextIndex = PlayerPrefs.GetInt("LevelData") + 1;
        Debug.Log(nextIndex);
        currentStage = stageDatas[nextIndex];
        targetScore = currentStage.targetObjective;
    }
}
