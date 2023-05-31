using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLoadScreen : MonoBehaviour
{
    void Start()
    {
        transform.DORotate(new Vector3(0, 0, 90),1)
            .SetRelative()
            .SetLoops(-1)
            .SetEase(Ease.Linear);
    }
}
