using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class CocosMovement : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private float fallGravity;
    [SerializeField] private ForceMode forceMode;
    [SerializeField] private float maxHeight;

    private Rigidbody CocosRB;

    void Start()
    {
        CocosRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y <= maxHeight)
        {
            CocosRB.AddForce(Vector3.up * force, forceMode);
        }

        CocosRB.AddForce(Vector3.down * fallGravity, ForceMode.Acceleration);
    }
}
