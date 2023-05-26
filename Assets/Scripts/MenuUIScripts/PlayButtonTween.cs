using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayButtonTween : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOScale(new Vector2(1f, 1f), 2f);
    }
}
