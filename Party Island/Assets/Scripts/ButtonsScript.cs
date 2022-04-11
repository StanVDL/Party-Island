using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("CocosCatcher");
        ScoreScript.instance.ResetPoints();
    }
}
