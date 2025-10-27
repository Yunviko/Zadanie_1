using UnityEngine;

public class PlayerControllerUpdate : MonoBehaviour
{
    public float moveSpeed = 100;
    public float jumpForce = 50;
    public float moveInput = 0;
    public bool jumpPressed = false;
    public float sprintSpeed = 500;
    public bool sprintPressed = false;  
    public int jumpCount = 0;
    public int maxJumps = 2;



    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public GroundChecker groundChecker;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        groundChecker = GetComponentInChildren<GroundChecker>();
    }


    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpPressed = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprintPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            spriteRenderer.color = Color.yellow;
        }

    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput * moveSpeed * Time.deltaTime, rb.velocity.y);
        if (groundChecker.isGrounded)
        {
            jumpCount = 0;
        }
        if (jumpPressed && jumpCount < maxJumps)
        {
           
            rb.AddForce(Vector2.up * jumpForce);
            jumpCount++;
        }
        jumpPressed = false;
        if (sprintPressed)
        {
            moveSpeed = sprintSpeed;
        }
        else
        {
            moveSpeed = 50;
        }

    }

}