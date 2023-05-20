using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScreen : MonoBehaviour
{
    TMP_Text text;
    [SerializeField] Catcher catcher;

    private void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        text.text = $"Score {catcher.GetScore()}";
    }
}
