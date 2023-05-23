using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foods : MonoBehaviour
{
    float fallSpeed = 5f;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Debug.Log(fallSpeed);
    }

    private void FixedUpdate()
    {
        Vector2 velocity = new Vector2(0, -fallSpeed);
        rb.velocity = velocity;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Catcher")
        {
            Destroy(gameObject);
        }
    }

    public void SetMinMax(float minimum, float maximum)
    {
        fallSpeed = Random.Range(minimum, maximum);
    }
}
