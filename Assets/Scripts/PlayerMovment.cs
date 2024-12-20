using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public float health;
    public Rigidbody rb;
    public bool beingControlled;
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Control"))
        {
            ChangeControl();
        }
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("vertical") != 0)
        {
            transform.forward = rb.velocity;
            transform.rotation = new Quaternion(0, transform.rotation.y, 0, transform.rotation.w);
        }
    }
    public void MovePlayer()
    {
        if (beingControlled)
        {
            rb.AddForce((Vector3.forward * Input.GetAxisRaw("Vertical") + Vector3.right * Input.GetAxisRaw("Horizontal")).normalized * moveSpeed);
        }
    }
    public void ChangeControl()
    {
        if (beingControlled)
        {
            beingControlled = false;
        }
        else
        {
            beingControlled = true;
        }
    }
}
