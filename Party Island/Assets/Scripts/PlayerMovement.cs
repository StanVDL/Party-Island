using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    public float gravity = -9.81f;

    public float jumpHeight = 3f;

    public Transform groundCheck;

    public float groundDistance = 0.4f;

    public LayerMask groundLayerMask;

    Vector3 velocity;

    bool isGrounded;

    void Update()
    {
        //Kijkt de positie na voor de isGrounded variable en kijkt of deze een ander object onder zich raakt
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayerMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Beweeg functie
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        //Zorgt dat er gesprongen kan worden met de player
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
