using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScreen : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [SerializeField] Catcher catcher;
    [SerializeField] Slider fillHealthySlider;
    [SerializeField] Slider fillUnhealthySlider;

    private void Start()
    {
        fillHealthySlider.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (catcher.GetScore() >= 0)
        {
            text.text = $"Score {catcher.GetScore()}";
            fillHealthySlider.gameObject.SetActive(true);
            fillHealthySlider.value = catcher.GetScore();
            fillUnhealthySlider.gameObject.SetActive(false);

            if (catcher.GetScore() == 10) 
            {
                // Win Statement
                Debug.Log("Win");
            }
        } else if (catcher.GetScore() <= 0)
        {
            text.text = $"Score {catcher.GetScore()}";
            fillUnhealthySlider.gameObject.SetActive(true);
            fillUnhealthySlider.value = Mathf.Abs(catcher.GetScore());
            fillHealthySlider.gameObject.SetActive(false);

            if (catcher.GetScore() == -10)
            {
                // Lose Statement
                Debug.Log("Lose");
            }
        }
    }
}
