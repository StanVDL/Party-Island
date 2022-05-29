using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]

public class CocosMovement : MonoBehaviour
{
    public float force;
    public float fallGravity;
    public ForceMode forceMode;
    public float maxHeight;
    private Rigidbody CocosRB;

    private bool playerIsAlive = true;

    public GameObject GameOverMenu;
    public GameObject PauseMenu;

    public static bool GameIsPaused = false;
    public static bool IsPauseMenuActive = false;

    //public GameObject TubePool;
    //public GameObject Tubes;

    void Start()
    {
        CocosRB = GetComponent<Rigidbody>();
        GameManager.Instance.OnPlayerDeath.AddListener(OnPlayerDeath);
        CocosRB.useGravity = false;
        Time.timeScale = 0;
        //TubePool.SetActive(false);
        //Tubes.SetActive(false);
    }

    //Zorgt dat speler niet direct dood is, dat de juiste functies opgeroepen worden en dat de pauze menu werkt
    void Update()
    {
        if (!playerIsAlive) return;

        FlyingCocos();

        FallSpeedDown();

       // if (Input.GetKeyDown(KeyCode.Escape) && IsPauseMenuActive == false)
        //{
         //   if (GameIsPaused)
          //  {
            //    Resume();
            //}

 //           else
   //         {
     //           Pause();
       //     }
        //}
    }

    //Bepaald te acties die uitgevoerd worden wanneer player dood is
    private void OnPlayerDeath()
    {
        playerIsAlive = false;
        GameOverMenu.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }

    //Zorgt ervoor dat de game start wanneer op spatie gedrukt wordt en die pas vanaf dan naar beneden valt
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

    //Zorgt dat de cocosnoot terug omhoog gaat bij het drukken op spatie
    void FlyingCocos()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y <= maxHeight)
        {
            //TubePool.SetActive(true);
            //Tubes.SetActive(true);
            Time.timeScale = 1;
            CocosRB.AddForce(Vector3.up * force, forceMode);
        }
    }

    //Functie om de game terug te doen hervatten en het menu te sluiten
    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    //Functie om de game te pauzeren en het menu te openen
    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
