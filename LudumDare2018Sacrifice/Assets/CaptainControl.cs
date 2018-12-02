﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainControl : MonoBehaviour {

    public float moveSpeed = 5f;
    public float moveSmooth = .3f;

    public Rigidbody2D rb;

    Vector2 movement = Vector2.zero;
    Vector2 velocity = Vector2.zero;


    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (!phasing.isSailing) { 
            Vector2 desiredVelocity = movement * moveSpeed;
            rb.velocity = Vector2.SmoothDamp(rb.velocity, desiredVelocity, ref velocity, moveSmooth);
        }
    }
}
