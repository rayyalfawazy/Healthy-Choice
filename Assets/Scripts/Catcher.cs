using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    int score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "HealthyFoods")
        {
            score += 1;
        }
        else if (collision.tag == "JunkFoods")
        {
            score -= 1;
        }
    }

    public int GetScore()
    {
        return score;
    }
}
