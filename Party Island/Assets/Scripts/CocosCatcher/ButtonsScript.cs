using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public GameObject CocosSpawner;

    //Functie om opnieuw te spelen vanuit het game over menu bij CocosCatcher
    public void PlayAgain()
    {
        SceneManager.LoadScene("CocosCatcher");
        CocosSpawner.SetActive(true);
        ScoreScript.instance.ResetPoints();
        Time.timeScale = 1;
    }

    //Functie om terug naar de lobby te gaan vanuit het game over menu bij CocosCatcher
    public void BackToLobby()
    {
        SceneManager.LoadScene("Island");
        Time.timeScale = 1;
    }
}
