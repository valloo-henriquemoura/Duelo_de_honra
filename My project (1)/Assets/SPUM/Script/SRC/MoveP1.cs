using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class MoveP1 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 4f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
           
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(speed, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-speed, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = new Vector2(0, -speed);
        }
        else
        {
            rb.linearVelocity = new Vector2(0, 0);
        }
    }
}
