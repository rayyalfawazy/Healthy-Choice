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
    [SerializeField] Slider fillHealthySlider, fillLifeSlider;
    [SerializeField] float slideSmoothness;

    private void Start()
    {
        ResetSliderValue();
    }

    private void Update()
    {

        if (playManager.scoreValue >= 0)
        {
            float currentVelocity = 0;
            float currentValue = Mathf.SmoothDamp(fillHealthySlider.value,
                                                playManager.scoreValue, ref currentVelocity,
                                                slideSmoothness * Time.deltaTime);
            fillHealthySlider.value = currentValue;
        }

        if (playManager.healthValue <= 10)
        {
            float currentVelocity = 0;
            float currentValue = Mathf.SmoothDamp(fillLifeSlider.value,
                                                playManager.healthValue, ref currentVelocity,
                                                slideSmoothness * Time.deltaTime);
            fillLifeSlider.value = currentValue;
        }
    }

    public void ResetSliderValue()
    {
        playManager.GetStageData();
        fillHealthySlider.maxValue = playManager.targetScore;
        fillLifeSlider.value = 10;
    }
}
