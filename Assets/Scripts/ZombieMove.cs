using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public Rigidbody2D rb;

    int timer;

    int direction;
    
    void Start()
    {
        timer = 0;
        direction = 2;
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer < 350)
        {
            rb.velocity = new Vector2(2, 0);
        }
        if (timer >= 350)
        {
            rb.velocity = new Vector2(-2, 0);
        }

        if (timer == 550)
        {
            timer = 0;
        }
        
    }
}
