using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform pos;
    public Transform PlayerPos;

    public float Speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pos.position.x > PlayerPos.position.x)
        {
            rb.velocity = new Vector2(-Speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(Speed, rb.velocity.y);
        }
    }
}
