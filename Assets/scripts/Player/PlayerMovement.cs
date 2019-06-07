
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float fMoveSpeed = 7;
    float fMoveInX;
    float fMoveInY;
    public float fJumpHeight=7;
    float fTurnSpeed =7;
    public bool bIsGrounded;
    public LayerMask WhatIsGround;
    public Transform tCheckPos;
    Rigidbody rb;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
        fMoveInX = Input.GetAxis("Horizontal");
        fMoveInY = Input.GetAxis("Vertical");
        bIsGrounded = Physics.CheckSphere(tCheckPos.position, 0.3f,WhatIsGround);
        //rb.velocity = new Vector3(fMoveInX * fMoveSpeed, rb.velocity.y, fMoveInY * fMoveSpeed);
        if (bIsGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, fJumpHeight, rb.velocity.z);//jumping
        }
        transform.Rotate(0, fMoveInX * fTurnSpeed, 0);
        //Debug.Log(tCheckPos.position);
    }
    private void LateUpdate()
    {
        rb.position += fMoveInY * transform.forward * Time.deltaTime * fMoveSpeed;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            GetComponent<Combat>().StartBattle();
            GetComponent<PlayerMovement>().fMoveSpeed = 0;
        }
    }
}
