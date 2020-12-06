using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTree : MonoBehaviour
{
    public Animator animator;


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Projectiles")
        {
            animator.SetBool("isDestroyed", true);
            Destroy(col.gameObject);
        }
    }
}
