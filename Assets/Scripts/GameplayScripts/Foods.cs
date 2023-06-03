using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foods : MonoBehaviour
{
    float fallSpeed;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Destroy Object off-screen
        if (transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
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
