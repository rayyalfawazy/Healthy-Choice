using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateLoadScreen : MonoBehaviour
{
    public GameObject animatedGameObject; // Object Yang Akan Di Animate

    void Start()
    {
        animatedGameObject.transform.DORotate(new Vector3(0, 0, 180),1)
            .SetRelative()
            .SetLoops(-1)
            .SetEase(Ease.Linear);
    }
}
