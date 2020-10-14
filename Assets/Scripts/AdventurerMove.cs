﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventurerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public BoxCollider2D boxCollider2d;
    //specifies which layers we want to hit with our ray cast (in this case only the "platforms" layer)
    [SerializeField] private LayerMask platformsLayerMask;
    float moveSpeed = 8f;

    private bool isGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 1f, platformsLayerMask);
        return raycastHit2d.collider != null;
    }

    
    
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // registers a key held down and returns true
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);

            
        }

        

        if (Input.GetKey(KeyCode.RightArrow))
        {
            // registers a key held down and returns true
            rb.velocity = new Vector2(+moveSpeed, rb.velocity.y);

            
        }

        if (isGrounded() && Input.GetKeyDown(KeyCode.UpArrow))
        {
            float jumpVelocity = 20f;
            rb.velocity = Vector2.up * jumpVelocity;
        }
        return;


    } 
}
