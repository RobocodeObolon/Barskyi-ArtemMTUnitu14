using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float fallMultiplier = 2.5f;

    private Rigidbody2D rb;
    private bool isGrounded;


    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Перевірка чи стоїмо на землі
        // isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groudLayer);


        // Стрибок
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded==true)
        {
            rb.AddForce(Vector2.up*jumpForce,ForceMode2D.Impulse);
        }

        // Прискорене падіння
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
           isGrounded = true; 
        }
        else
        {
            isGrounded = false;  
        }
    }
}
