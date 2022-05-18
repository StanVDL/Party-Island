using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem instance;

    public static int scoreValue2 = 0;
    public static int highscoreValue2 = 0;

    public Text score2;
    public Text highScore2;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        //Zorgt ervoor dat de highscore opgeslagen wordt
        highscoreValue2 = PlayerPrefs.GetInt("highscoreFlappys", highscoreValue2);

        //Toont de score en highscore tekst met hun standaard waarde 0
        score2.text = "Score: " + scoreValue2.ToString();
        highScore2.text = "Highscore: " + highscoreValue2.ToString();
    }

    //Functie die er voor zorgt dat de score met 1 vermeerderd wordt en de highscore aanpast indien dit nodig is
    public void AddPoint()
    {
        scoreValue2 += 1;
        score2.text = "Score: " + scoreValue2.ToString();

        if (highscoreValue2 < scoreValue2)
        {
            PlayerPrefs.SetInt("highscoreFlappys", scoreValue2);
        }
    }

    //Functie die de score van FlappyCocos reset wanneer de game opnieuw gestart wordt
    public void ResetPoints()
    {
        scoreValue2 = 0;
        score2.text = "Score: " + scoreValue2.ToString();
    }
}
