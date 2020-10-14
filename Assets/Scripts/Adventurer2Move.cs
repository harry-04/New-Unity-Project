using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurer2Move : MonoBehaviour
{
    // Start is called before the first frame update
<<<<<<< HEAD
    SpriteRenderer sr;
    public Sprite jumpSprite;
    public Sprite standSprite;
    public Rigidbody2D rigidbody2d;
=======
    public Rigidbody2D rb;
>>>>>>> d053126bc3a4dc38cf9a3d1b574cecb603ea37e9
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
<<<<<<< HEAD
        sr = GetComponent<SpriteRenderer>();
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
=======
        rb = transform.GetComponent<Rigidbody2D>();
>>>>>>> d053126bc3a4dc38cf9a3d1b574cecb603ea37e9
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            // registers a key held down and returns true
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);


        }



        if (Input.GetKey(KeyCode.D))
        {
            // registers a key held down and returns true
            rb.velocity = new Vector2(+moveSpeed, rb.velocity.y);


        }

        if (isGrounded() && Input.GetKeyDown(KeyCode.W))
        {
            float jumpVelocity = 20f;
<<<<<<< HEAD
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            sr.sprite = jumpSprite;
=======
            rb.velocity = Vector2.up * jumpVelocity;
>>>>>>> d053126bc3a4dc38cf9a3d1b574cecb603ea37e9
        }
        return;

        if (rigidbody2d.velocity = new Vector2(0 + 0)
        {
            sr.sprite = jumpSprite;
        }
    }
}
