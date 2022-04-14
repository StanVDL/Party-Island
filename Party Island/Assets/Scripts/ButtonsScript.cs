using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public GameObject CocosSpawner;

    public void PlayAgain()
    {
        SceneManager.LoadScene("CocosCatcher");
        CocosSpawner.SetActive(true);
        ScoreScript.instance.ResetPoints();
    }

    public void BackToLobby()
    {
        SceneManager.LoadScene("Island");
    }
}
