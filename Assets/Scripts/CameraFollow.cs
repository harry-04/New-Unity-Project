﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour{


    public Transform playerTransform;

    

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        
        
    }

    void LateUpdate()
    {
        Vector3 temp = transform.position;

        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;

        transform.position = temp;
    }

    void FixedUpdate()
    {
       
    }
}