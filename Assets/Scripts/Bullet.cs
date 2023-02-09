using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveDirection;
    public bool isParented = true;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (transform.parent == null)
        {
            rb.MovePosition(
                (Vector2)transform.position + moveDirection * Time.fixedDeltaTime);
        }
        else
        {
            if (Input.GetKey("space"))
            {
                StartMoving(new Vector2(1, 1));
            }
        }
    }

    private void StartMoving(Vector2 direction)
    {
        transform.parent = null;
        moveDirection = direction;
    }
}
