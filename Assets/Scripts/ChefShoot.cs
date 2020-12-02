using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChefShoot : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform armEnd;
    public Animator animator;
  
    
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            animator.SetBool("shoot", true);
        }
        else
        {
            animator.SetBool("shoot", false);
        }
    }



    public void Shoot()
    {
        Rigidbody projectileInstance;
        projectileInstance = Instantiate(projectile, armEnd.position, armEnd.rotation) as Rigidbody;
        projectileInstance.AddForce(-armEnd.forward * 350f);
    }
}
