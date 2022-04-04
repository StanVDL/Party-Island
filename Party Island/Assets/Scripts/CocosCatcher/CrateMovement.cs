using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateMovement : MonoBehaviour
{
    private Rigidbody rb;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        if (h > 0)
        {
            rb.velocity = Vector3.right * speed;
        }

        else if (h < 0)
        {
            rb.velocity = Vector3.left * speed;
        }

        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}
