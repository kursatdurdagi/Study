using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(Collider))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] Joystick joystick;
    [SerializeField] Animator anim;

    public float movespeed;


    void Start()
    {
        rb.isKinematic = false;
    }


    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        rb.velocity = new Vector3(joystick.Horizontal * movespeed, rb.velocity.y, joystick.Vertical * movespeed);
        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }

  
}
