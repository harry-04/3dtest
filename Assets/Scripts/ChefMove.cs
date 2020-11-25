using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChefMove : MonoBehaviour
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
        if (Input.GetKey("down"))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -moveSpeedZ);
            animator.SetBool("chefwalk_s", true);
        }
        else
        {
            animator.SetBool("chefwalk_s", false);
        }

        if (Input.GetKey("left"))
        {
            rb.velocity = new Vector3(-moveSpeedX, rb.velocity.y, rb.velocity.z);
            animator.SetBool("chefwalk_a", true);
        }
        else
        {
            animator.SetBool("chefwalk_a", false);
        }

        if (Input.GetKey("up"))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, +moveSpeedZ);
            animator.SetBool("chefwalk_w", true);
        }
        else
        {
            animator.SetBool("chefwalk_w", false);
        }

        if (Input.GetKey("right"))
        {
            rb.velocity = new Vector3(+moveSpeedX, rb.velocity.y, rb.velocity.z);
            animator.SetBool("chefwalk_d", true);
        }
        else
        {
            animator.SetBool("chefwalk_d", false);
        }



    }
}
