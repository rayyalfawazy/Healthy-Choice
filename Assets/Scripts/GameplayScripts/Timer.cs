using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] PlayManager playManager;
    [SerializeField] TMP_Text sequenceText;
    public UnityEvent onComplete;

    public void PreStartTimer()
    {
        var sequence = DOTween.Sequence();
        sequenceText.transform.localScale = Vector3.zero;
        sequenceText.text = playManager.currentStage.stageName;

        sequence.Append(sequenceText.transform.DOScale(Vector3.one, 1)
            .OnComplete(() =>
            {
                sequenceText.transform.localScale = Vector3.zero;
                sequenceText.text = "3";
            }));

        sequence.Append(sequenceText.transform.DOScale(Vector3.one, 1)
            .OnComplete(() =>
            {
                sequenceText.transform.localScale = Vector3.zero;
                sequenceText.text = "2";
            }));

        sequence.Append(sequenceText.transform.DOScale(Vector3.one, 1)
            .OnComplete(() =>
            {
                sequenceText.transform.localScale = Vector3.zero;
                sequenceText.text = "1";
            }));

        sequence.Append(sequenceText.transform.DOScale(Vector3.one, 1)
            .OnComplete(() =>
            {
                sequenceText.transform.localScale = Vector3.zero;
                sequenceText.text = "Mulai!";
            }));

        sequence.Append(sequenceText.transform.DOScale(Vector3.one, 1)
            .OnComplete(() =>
            {
                sequenceText.transform.localScale = Vector3.zero;
                onComplete.Invoke();
                DOTween.KillAll();
            }));
    }
}
