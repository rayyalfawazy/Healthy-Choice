using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PreStartScreen : MonoBehaviour
{
    [SerializeField] PlayManager playManager;
    [SerializeField] TextMeshProUGUI preStartText;

    void Start()
    {
        PreStart();
    }

    public void PreStart()
    {
        preStartText.text = playManager.currentStage.stageName;
    }
}
