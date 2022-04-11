using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;

    public static int scoreValue = 0;
    public static int highscoreValue = 0;

    public Text score;
    public Text highScore;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highscoreValue = PlayerPrefs.GetInt("highscore", highscoreValue);

        score.text = "Score: " + scoreValue.ToString();
        highScore.text = "Highscore: " + highscoreValue.ToString();
    }

    public void AddPoint()
    {
        scoreValue += 1;
        score.text = "Score: " + scoreValue.ToString();

        if (highscoreValue < scoreValue)
        {
            PlayerPrefs.SetInt("highscore", scoreValue);
        }
    }

    public void ResetPoints()
    {
        scoreValue = 0;
        score.text = "Score: " + scoreValue.ToString();
    }
}
