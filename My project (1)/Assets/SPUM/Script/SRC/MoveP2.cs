using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class MoveP2 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.linearVelocity = new Vector2(speed, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.linearVelocity = new Vector2(-speed, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.linearVelocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.linearVelocity = new Vector2(0, -speed);
        }
        else
        {
            rb.linearVelocity = new Vector2(0, 0);
        }
    }
}
