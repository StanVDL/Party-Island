using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeController : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Start()
    {
        GameManager.Instance.OnPlayerDeath.AddListener(OnPlayerDeath);
    }

    void Update()
    {
        transform.position += Vector3.left * (speed * Time.deltaTime);
    }

    private void OnPlayerDeath()
    {
        speed = 0f;
    }
}
