using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;
    public static int Health;

    public GameObject gameOverMenu;

    public GameObject CocosSpawner;

    void Start()
    {
        Health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
    }

    void Update()
    {
        switch(Health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOverMenu.gameObject.SetActive(true);
                CocosSpawner.SetActive(false);
                CrateMovement.instance.NoHeartsLeft();
                Cursor.lockState = CursorLockMode.None;
                break;
        }
    }
}
