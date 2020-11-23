using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdinMove : MonoBehaviour
{
    public Rigidbody rb;
    public BoxCollider boxCollider;
    public float moveSpeedX = 1f;
    public float moveSpeedZ = 1f;
    public float moveSpeedY = 1f;
    public Animator animator;



    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
        boxCollider = transform.GetComponent<BoxCollider>();
    }

    



    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-moveSpeedX, rb.velocity.y, rb.velocity.z);
            animator.SetBool("walk_a", true);
        }
        else
        {
            animator.SetBool("walk_a", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(+moveSpeedX, rb.velocity.y, rb.velocity.z);
            animator.SetBool("walk_d", true);
        }
        else
        {
            animator.SetBool("walk_d", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, +moveSpeedZ);
            animator.SetBool("walk_w", true);
        }
        else
        {
            animator.SetBool("walk_w", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -moveSpeedZ);
            animator.SetBool("walk_s", true);
        }
        else
        {
            animator.SetBool("walk_s", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, +moveSpeedY, rb.velocity.z);
        }
        
    }
}
