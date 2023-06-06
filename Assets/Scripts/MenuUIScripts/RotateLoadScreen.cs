using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RotateLoadScreen : MonoBehaviour
{
    public GameObject animated;
    public TMP_Text randomText;
    [TextArea] public List<string> loadingRandomText;

    void Start()
    {
        AnimateLoadScreen();
        GenerateRandomText();
    }

    void AnimateLoadScreen()
    {
        animated.transform.DORotate(new Vector3(0, 0, 359), 2)
            .SetRelative()
            .SetLoops(-1)
            .SetEase(Ease.Linear);
    }

    void GenerateRandomText()
    {
        int randomIndex = Random.Range(0, loadingRandomText.Count);
        for (int i = 0; i < loadingRandomText.Count; i++)
        {
            if (i == randomIndex)
            {
                randomText.text = loadingRandomText[i];
            }
        }
    }
}
