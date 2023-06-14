using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    public int score;
    public int health;
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
            health -= 1;
            unhealthyAudioSource.Play();
        }
    }
}
