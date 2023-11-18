using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    Rigidbody2D robotRD;
    Animator animator;

    private float walkSpeed = 10f;
    private float maxSpeed = 3f;
    private float jumpPower = 3f;
    private bool isJump;

    void Start()
    {
        isJump = false;
        robotRD = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float speedx = Mathf.Abs(robotRD.velocity.x);

        if ((Input.GetKey(KeyCode.Space)) && isJump)
        {
            robotRD.AddForce(transform.up * jumpPower, ForceMode2D.Impulse);
            animator.SetTrigger("JumpCall");
        }

        if (speedx < maxSpeed)
        {
            if (Input.GetKey(KeyCode.A))
            {
                robotRD.AddForce(transform.right * -1 * walkSpeed);
                transform.localScale = new Vector3(-1.0f, 1.0f, 1);
                animator.SetTrigger("WalkCall");
            }
            else if (Input.GetKeyUp(KeyCode.A)) animator.SetTrigger("IdleCall");

            if (Input.GetKey(KeyCode.D))
            {
                robotRD.AddForce(transform.right * walkSpeed);
                transform.localScale = new Vector3(1.0f, 1.0f, 1);
                animator.SetTrigger("WalkCall");
            }
            else if (Input.GetKeyUp(KeyCode.D)) animator.SetTrigger("IdleCall");
        }
        //animator.speed = speedx / 3.0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJump = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJump = false;
        }
    }
}
