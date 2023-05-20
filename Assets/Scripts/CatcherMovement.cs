using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class CatcherMovement : MonoBehaviour
{
    [Range(0,10)] public float speed = 5f;
    [SerializeField] float boundScale;

    [SerializeField] Rigidbody2D rb;

    private void FixedUpdate()
    {
        // Get Movement Axis
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Movement
        Vector2 movement = new Vector2(moveHorizontal, 0f);
        rb.velocity = movement * speed;

        // Position Bounds
        Vector2 clampedPosition = rb.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -boundScale, boundScale);
        rb.position = clampedPosition;
    }
}
