using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventurerMove : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rb;
    

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rb.velocity;

        velocity.x = 0;
        velocity.y = 7;
        


        float xSpeed = 5.0f;
        float ySpeed = 5.0f;
        if (Input.GetKey("left"))
        {
            // registers a key held down and returns true

            rb.velocity = new Vector2(-5, 0);
        }

        

        if (Input.GetKey("right"))
        {
            // registers a key held down and returns true

            rb.velocity = new Vector2(5, 0);
        }

        if (Input.GetKey("up"))
        {
            rb.velocity=velocity;
        }
        return;

        if (Input.GetKey("down"))
        {
            // registers a key held down and returns true

            ySpeed = -5.0f;
            transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);
        }

    } 
}
