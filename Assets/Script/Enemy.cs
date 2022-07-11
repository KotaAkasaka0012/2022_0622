using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    public LayerMask groundLayer;
    private Rigidbody2D rb2d;
    private SpriteRenderer spRenderer;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        spRenderer = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x;
        if (transform.rotation.y == 180)
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        rb2d.AddForce(Vector2.right * x * speed);
    }
}
