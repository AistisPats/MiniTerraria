using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private float moveInput;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumpimg;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumpimg = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKey(KeyCode.Space) && isJumpimg == true)

            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
                isJumpimg = false;
        {

            {
            }
        }

        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                isJumpimg = false;
            }
        }
    }
}