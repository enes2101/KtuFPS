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
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        

        rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        
        
    }

    
}
