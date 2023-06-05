using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    int score;
    public AudioSource healthyAudioSource, unhealthyAudioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "HealthyFoods")
        {
            score += 1;
            healthyAudioSource.Play();
        }
        else if (collision.tag == "JunkFoods")
        {
            score -= 1;
            unhealthyAudioSource.Play();
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
