using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public Animator anim;
    Rigidbody rb;
    PlayerMovement pm;
    // Start is called before the first frame update
    void Start()
    {
        
        pm = GetComponent<PlayerMovement>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.W)&& pm.bIsGrounded)||(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.D))||Input.GetKey(KeyCode.S)&&pm.bIsGrounded)
        {
            anim.SetBool("isWalking", true);
        }
        else if(pm.bIsGrounded)
        {
            anim.SetBool("isWalking", false);
        }

        if (!pm.bIsGrounded)
        {
            anim.SetBool("isJumping",true);
        }
        else
        {
            anim.SetBool("isJumping",false);
        }
    }
    
}
