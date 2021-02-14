﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    float directionOffset = 90f;


    Rigidbody2D rb;
    public Camera cam;


    Vector2 mousePos;
    Vector2 movement;
    


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetKeyDown("1"))
        {
            directionOffset = 180f;
        }

        if (Input.GetKeyDown("0"))
        {
            directionOffset = 90f;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * _moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - directionOffset;
        rb.rotation = angle;
    }
}
