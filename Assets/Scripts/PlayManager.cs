using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PlayManager : MonoBehaviour
{
    [SerializeField] Catcher catcher;
    [SerializeField] int targetScore;
    [SerializeField] UnityEvent onWin, onLose;

    [System.NonSerialized] public int value;

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
}
