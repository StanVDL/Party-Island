using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeController : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        transform.position += Vector3.left * (speed * Time.deltaTime);
    }
}
