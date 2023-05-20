using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foods : MonoBehaviour
{
    [SerializeField] ScoreSystem scoreSystem;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Catcher")
        {
            Destroy(gameObject);
        }
    }
}
