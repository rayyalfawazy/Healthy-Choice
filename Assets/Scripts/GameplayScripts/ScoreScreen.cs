using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreScreen : MonoBehaviour
{
    [SerializeField] PlayManager playManager;
    [SerializeField] Catcher catcher;
    [SerializeField] Slider fillHealthySlider, fillUnhealthySlider;
    [SerializeField] float slideSmoothness;

    private void Start()
    {
        SetSliderValue();
    }

    private void Update()
    {

        if (playManager.value >= 0)
        {
            float currentVelocity = 0;
            float currentValue = Mathf.SmoothDamp(fillHealthySlider.value,
                                                playManager.value, ref currentVelocity,
                                                slideSmoothness * Time.deltaTime);
            fillHealthySlider.value = currentValue;
        }

        if (playManager.value <= 0)
        {
            float currentVelocity = 0;
            float currentValue = Mathf.SmoothDamp(fillUnhealthySlider.value,
                                                Mathf.Abs(playManager.value), ref currentVelocity,
                                                slideSmoothness * Time.deltaTime);
            fillUnhealthySlider.value = currentValue;
        }
    }

    public void SetSliderValue()
    {
        playManager.GetStageData();
        fillHealthySlider.maxValue = playManager.targetScore;
        fillUnhealthySlider.maxValue = playManager.targetScore;
    }
}
