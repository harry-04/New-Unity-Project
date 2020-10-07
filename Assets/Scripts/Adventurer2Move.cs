using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurer2Move : MonoBehaviour
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
        transform.position = new Vector3 (Adventurer2Move.position.x + offset.x, Adventurer2Move.position.y + offset.y, offset.z);
        float xSpeed = 5.0f;
        float ySpeed = 5.0f;
        if (Input.GetKey("a"))
        {
            // registers a key held down and returns true

            xSpeed = -5.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
        }

        

        if (Input.GetKey("d"))
        {
            // registers a key held down and returns true

            xSpeed = 5.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector3(0, 10, 0);
        }
        return;

        if (Input.GetKey("s"))
        {
            // registers a key held down and returns true

            ySpeed = -5.0f;
            transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);
        }

    } 
}
