using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurer2Move : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidbody2d;
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
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            // registers a key held down and returns true (rigidbody2d.velocity is just a longer version of rb.velocity)
            rigidbody2d.velocity = new Vector2(-moveSpeed, rigidbody2d.velocity.y);

            
        }

        

        if (Input.GetKey(KeyCode.D))
        {
            // registers a key held down and returns true
            rigidbody2d.velocity = new Vector2(+moveSpeed, rigidbody2d.velocity.y);

            
        }

        if (isGrounded() && Input.GetKeyDown(KeyCode.W))
        {
            float jumpVelocity = 20f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }
        return;


    } 
}
