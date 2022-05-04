using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    //Functie om opnieuw te spelen vanuit het game over menu bij CocosCatcher
    public void PlayAgain()
    {
        SceneManager.LoadScene("FlappyCocos");
        ScoreSystem.instance.ResetPoints();
    }

    //Functie om terug naar de lobby te gaan vanuit het game over menu bij CocosCatcher
    public void BackToLobby()
    {
        SceneManager.LoadScene("Island");
    }
}
