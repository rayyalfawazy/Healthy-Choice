using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreScreen : MonoBehaviour
{
    [SerializeField] Catcher catcher;
    [SerializeField] Slider fillHealthySlider, fillUnhealthySlider;
    [SerializeField] float slideSmoothness;
    [SerializeField] UnityEvent onWin, onLose;

    private void Update()
    {
        if (catcher.GetScore() >= 0)
        {
            int value = catcher.GetScore();
            float currentVelocity = 0;
            float currentValue = Mathf.SmoothDamp(fillHealthySlider.value,
                                                value, ref currentVelocity,
                                                slideSmoothness * Time.deltaTime);

            fillHealthySlider.value = currentValue;

            if (catcher.GetScore() == 10) 
            {
                // Win Statement
                onWin.Invoke();
            }
        } 
        
        if (catcher.GetScore() <= 0)
        {
            int value = Mathf.Abs(catcher.GetScore());
            float currentVelocity = 0;
            float currentValue = Mathf.SmoothDamp(fillUnhealthySlider.value,
                                                value, ref currentVelocity,
                                                slideSmoothness * Time.deltaTime);

            fillUnhealthySlider.value = currentValue;

            if (catcher.GetScore() == -10)
            {
                // Lose Statement
                onLose.Invoke();
            }
        }
    }
}
