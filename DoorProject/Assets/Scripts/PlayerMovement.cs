using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 5f;

    private float xInput;
    private float zInput;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {
        ProcessInputs();
        
    }

    private void FixedUpdate()
    {
        Move();
    }
    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
    }
}
