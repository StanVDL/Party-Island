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
        //Zorgt ervoor dat de highscore opgeslagen wordt
        highscoreValue = PlayerPrefs.GetInt("highscores", highscoreValue);

        //Toont de score en highscore tekst met hun standaard waarde 0
        score.text = "Score: " + scoreValue.ToString();
        highScore.text = "Highscore: " + highscoreValue.ToString();
    }

    //Functie die er voor zorgt dat de score met 1 vermeerderd wordt en de highscore aanpast indien dit nodig is
    public void AddPoint()
    {
        scoreValue += 1;
        score.text = "Score: " + scoreValue.ToString();

        if (highscoreValue < scoreValue)
        {
            PlayerPrefs.SetInt("highscores", scoreValue);
        }
    }

    //Functie die de score van CocosCatcher reset wanneer de game opnieuw gestart wordt
    public void ResetPoints()
    {
        scoreValue = 0;
        score.text = "Score: " + scoreValue.ToString();
    }
}
