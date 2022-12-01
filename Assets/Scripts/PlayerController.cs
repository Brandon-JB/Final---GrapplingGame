using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float speed = 10f;
    private float jumpingPower = 10f;
    private bool isFacingRight = true;
    public bool PlayerCode = true;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundlayer;
    [SerializeField] GameObject GameOverScreen;
    //public AudioSource GameOver;
    //public GameObject AudioObject;

    void Start()
    {

    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        if (Input.GetKeyDown("escape"))
        {
            GameOverScreen.SetActive(true);
            Time.timeScale = 0f;
        }

        //flip();
    }

    private void fixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
    }

    private void flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;

            //Vector3 localScale = transform.localScale;
            //localScale.x *= -1f;
            //transform.localScale = localScale;

            transform.Rotate(0f, 180f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Level1Trigger")
        {
            SceneManager.LoadScene("Level 1");
        }
        else if (collision.gameObject.tag == "Level2Trigger")
        {
            SceneManager.LoadScene("Level 2");
        }
        else if (collision.gameObject.tag == "Level3Trigger")
        {
            SceneManager.LoadScene("Level 3");
        }
    }

}
