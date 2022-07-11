using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 400f;
    public LayerMask groundLayer;
    public GameManager gamemanager;
    private Rigidbody2D rb2d;
    private SpriteRenderer spRenderer;
    private bool isGround;
    private bool isDead = false;

    void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
        this.spRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (!isDead)
        {
            float x = Input.GetAxisRaw("Horizontal");

            if (x < 0)
            {
                spRenderer.flipX = true;
            }
            else if (x > 0)
            {
                spRenderer.flipX = false;
            }
            rb2d.AddForce(Vector2.right * x * speed);

            if (Input.GetButtonDown("Jump") & isGround)
            {
                rb2d.AddForce(Vector2.up * jumpForce);
            }


            float velx = rb2d.velocity.x;
            float vely = rb2d.velocity.y;

            if (Mathf.Abs(velx) > 5)
            {
                if (velx > 5.0f)
                {
                    rb2d.velocity = new Vector2(5.0f, vely);
                }
                if (velx < -5.0f)
                {
                    rb2d.velocity = new Vector2(-5.0f, vely);
                }
            }
        }
    }

    private void FixedUpdate()
    {
        isGround = false;

        Vector2 groundPos = new Vector2(transform.position.x, transform.position.y);
        Vector2 groundArea = new Vector2(0.4f, 1.5f);
        //Debug.DrawLine(groundPos + groundArea, groundPos - groundArea, Color.red);

        isGround = Physics2D.OverlapArea(groundPos + groundArea, groundPos - groundArea, groundLayer);
        
        //Debug.Log(isGround);
    }

    void OnCollisionEnter2D(Collision2D Collision)
    {
        if(Collision.gameObject.tag == "GameOver")
        {
            isDead = true;
            StartCoroutine("GameOver");
            //Debug.Log("damage");
            //gamemanager.GameOver();
            SceneManager.LoadScene("GameOverScene");
        }

        if(Collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}