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
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(+moveSpeedX, rb.velocity.y, rb.velocity.z);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, +moveSpeedZ);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -moveSpeedZ);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, +moveSpeedY, rb.velocity.z);
        }
        
    }
}
