using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeController : MonoBehaviour
{
    public float speed;

    public GameObject ScoreTrigger;

    void Start()
    {
        GameManager.Instance.OnPlayerDeath.AddListener(OnPlayerDeath);
    }

    //Update functie waarin gezorgd wordt dat de tubes bewegen
    void Update()
    {
        transform.position += Vector3.left * (speed * Time.deltaTime);
    }

    //Stopt de tube movement wanneer player dood is
    public void OnPlayerDeath()
    {
        speed = 0f;
    }

    //Voegt 1 punt toe aan de score wanneer de player door de tube opening gaat
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && gameObject == ScoreTrigger)
        {
            ScoreSystem.instance.AddPoint();
        }
    }
}
