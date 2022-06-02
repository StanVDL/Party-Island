using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public GameObject CocosSpawner;
    public GameObject gameOverMenu;

    //Functie om opnieuw te spelen vanuit het game over menu bij CocosCatcher
    public void PlayAgain()
    {
        SceneManager.LoadScene("CocosCatcher");
        CocosSpawner.SetActive(true);
        ScoreScript.instance.ResetPoints();
        gameOverMenu.SetActive(false);
    }

    //Functie om terug naar de lobby te gaan vanuit het game over menu bij CocosCatcher
    public void BackToLobby()
    {
        SceneManager.LoadScene("Island");
        gameOverMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
