using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderMove : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float moveSmooth = .3f;

    public Rigidbody2D rb;

    Vector2 movement = Vector2.zero;
    Vector2 velocity = Vector2.zero;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = -1*Input.GetAxisRaw("Horizontal");
        movement.y = -1*(Input.GetAxisRaw("Vertical")+2f);
    }

    private void FixedUpdate()
    {
        Vector2 desiredVelocity = movement * moveSpeed;
        rb.velocity = Vector2.SmoothDamp(rb.velocity, desiredVelocity, ref velocity, moveSmooth);
    }
}
