using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovesRigitBody : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public LayerMask groundLayers;
    public float jumpForce;
    public float jumpHeight;
    public bool isGrounded=true;
    public Transform myTrans;
    public Transform groundTag;
    public bool PlayerJump=false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    public void JumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        JumpInput();
        
    }



    private void PlayerMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);


        rb.AddForce(movement * speed);

        

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="ground")
        {
            isGrounded = true;
        }
    }
}