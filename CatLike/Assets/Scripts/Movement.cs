using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D playerRB;
    Animator animator;

    private AudioSource myAudioSource;
    public float moveSpeed = 1f;
    public float jumpSpeed = 1f, jumpFrequency = 1f, nextJumpTime;



    bool facingRight = true;
    public bool isGrounded = false;
    public Transform groundCheckPosition;
    public float groundCheckRadius;
    public LayerMask groundCheckLayer;

    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        playerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetBool("Jumping", false);
        StartCoroutine(CatSound());
    }
    IEnumerator CatSound()
    {
        yield return new WaitForSeconds(Random.Range(7, 13));
        FindObjectOfType<AudioManager>().Play("miyaw");
        Debug.Log("miyaw");
        StartCoroutine(CatSound());
    }


    void Update()
    {
        HorizontalMove();
        OnGroundCheck();
        if (playerRB.velocity.x < 0 && facingRight)
        {
            FlipFace();
        }
        else if (playerRB.velocity.x > 0 && !facingRight)
        {
            FlipFace();
        }
        if (Input.GetAxis("Vertical") > 0 && isGrounded && (nextJumpTime < Time.timeSinceLevelLoad))
        {
            nextJumpTime = Time.timeSinceLevelLoad + jumpFrequency;
            Jump();
        }
        Animations();
    }
    void Animations()
    {
        if (isGrounded == false)
        {
            animator.SetBool("Jumping", true);
        }
        else
        {
            animator.SetBool("Jumping", false);
        }
        if (Mathf.Abs(playerRB.velocity.x) >= 0.1f)
        {
            animator.SetBool("IsMoving", true);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }
    }
    void HorizontalMove()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, playerRB.velocity.y);
    }

    void FlipFace()
    {
        facingRight = !facingRight;
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x *= -1;
        transform.localScale = tempLocalScale;
    }
    void Jump()
    {

        playerRB.AddForce(new Vector2(0f, jumpSpeed));
        FindObjectOfType<AudioManager>().Play("jump");

    }

    void OnGroundCheck()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, groundCheckLayer);

    }


}
