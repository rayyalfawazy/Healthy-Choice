using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RotateLoadScreen : MonoBehaviour
{
    public GameObject animated;

    void Start()
    {
        AnimateLoadScreen();
    }

    void AnimateLoadScreen()
    {
        animated.transform.DORotate(new Vector3(0, 0, 359), 2)
            .SetRelative()
            .SetLoops(-1)
            .SetEase(Ease.Linear);
    }
}
