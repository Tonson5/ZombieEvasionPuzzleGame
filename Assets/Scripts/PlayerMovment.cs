using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public float health;
    public Rigidbody rb;
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        rb.AddForce((Vector3.forward * Input.GetAxisRaw("Vertical") + Vector3.right * Input.GetAxisRaw("Horizontal")).normalized * moveSpeed);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
