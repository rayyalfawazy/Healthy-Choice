using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("Triggered");

        if (collision.tag == "HealthyFoods")
        {
            Debug.Log(collision.tag);
        }
        else if (collision.tag == "JunkFoods")
        {
            Debug.Log(collision.tag);
        }
        else
        {
            return;
        }
    }
}
