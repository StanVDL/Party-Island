using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]

public class CocosMovement : MonoBehaviour
{
    [SerializeField] private float force;
    public float fallGravity;
    [SerializeField] private ForceMode forceMode;
    [SerializeField] private float maxHeight;
    private Rigidbody CocosRB;

    private bool playerIsAlive = true;

    public GameObject GameOverMenu;

    void Start()
    {
        CocosRB = GetComponent<Rigidbody>();
        GameManager.Instance.OnPlayerDeath.AddListener(OnPlayerDeath);
        CocosRB.useGravity = false;
    }

    void Update()
    {
        if (!playerIsAlive) return;

        FlyingCocos();

        FallSpeedDown();
    }

    private void OnPlayerDeath()
    {
        playerIsAlive = false;
        GameOverMenu.SetActive(true);
        Time.timeScale = 0;
    }

    void FallSpeedDown()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CocosRB.useGravity = true;
        }

        if (CocosRB.useGravity == true)
        {
            CocosRB.AddForce(Vector3.down * fallGravity, ForceMode.Acceleration);
        }      
    }

    void FlyingCocos()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y <= maxHeight)
        {
            CocosRB.AddForce(Vector3.up * force, forceMode);
        }
    }
}
