using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject GameOverMenu;

    //Functie om opnieuw te spelen vanuit het game over menu bij FlappyCocos
    public void PlayAgain()
    {
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("FlappyCocos");
        ScoreSystem.instance.ResetPoints();
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }

    //Functie om terug naar de lobby te gaan vanuit het game over menu bij FlappyCocos
    public void BackToLobby()
    {
        SceneManager.LoadScene("Island");
    }
}
