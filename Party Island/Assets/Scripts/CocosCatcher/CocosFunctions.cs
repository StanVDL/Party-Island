using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocosFunctions : MonoBehaviour
{
    public GameObject GoodCoconut;
    public GameObject BadCoconut;

    public float fallSpeed;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //Functie die de cocos valsnelheid insteld met de variabele fallSpeed
        if (rb.velocity.magnitude > fallSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, fallSpeed);
        }
    }

    //Voert acties uit wanneer objecten met de desbetreffende tag geraakt worden
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Crate" && gameObject == GoodCoconut)
        {
            Destroy(gameObject);
            ScoreScript.instance.AddPoint();
        }

        if (collision.gameObject.tag == "Crate" && gameObject == BadCoconut)
        {
            Destroy(gameObject);
            HeartScript.Health -= 1;
        }
    }


}
