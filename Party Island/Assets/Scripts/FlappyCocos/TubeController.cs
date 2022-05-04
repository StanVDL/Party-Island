using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeController : MonoBehaviour
{
    [SerializeField] private float speed;

    public GameObject ScoreTrigger;

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && gameObject == ScoreTrigger)
        {
            ScoreSystem.instance.AddPoint();
        }
    }
}
