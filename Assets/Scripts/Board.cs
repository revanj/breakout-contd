using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Board : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public float moveLimit = 6.3f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var direction = Input.GetAxis("Horizontal");
        var targetPos = Vector3.right  * // (1, 0, 0) 
                        (direction * Time.fixedDeltaTime * speed) 
                        + transform.position;
        if (targetPos.x > moveLimit)
        {
            targetPos.x = moveLimit;
        }
        if (targetPos.x < -moveLimit)
        {
            targetPos.x = -moveLimit;
        }
        
        rb.MovePosition(targetPos);
    }
}
