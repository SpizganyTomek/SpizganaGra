using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isjumping", true);
        }
    }

    public void OnLanding ()
    {
        animator.SetBool("isjumping", false);
    }


    void FixedUpdate()
    {
        controller.Move(0f, false, jump);
        jump = false;
    }

}
