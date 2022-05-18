using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAchievements : MonoBehaviour
{
    public GameObject CocosCatcherCheckmark1, CocosCatcherCheckmark2, CocosCatcherCheckmark3;
    public GameObject FlappyCocosCheckmark1, FlappyCocosCheckmark2, FlappyCocosCheckmark3;

    int HighscoreValueCheck;
    int HighscoreValueCheck2;

    void Start()
    {
        //Haalt de highscore vanuit CocosCatcher reeds op in de lobby zodat de reeds voltooide achievements al inladen in het menu
        HighscoreValueCheck = PlayerPrefs.GetInt("highscore");
        HighscoreValueCheck2 = PlayerPrefs.GetInt("highscoreFlappy");
    }

    void Update()
    {
        CocosCatcherAchievement1();
        CocosCatcherAchievement2();
        CocosCatcherAchievement3();
    }

    //Functie van de 3de achievement bij CocosCatcher
    void CocosCatcherAchievement1()
    {
        if (ScoreScript.scoreValue >= 10 && HeartScript.Health == 1)
        {
            CocosCatcherCheckmark1.SetActive(true);
        }
    }

    //Functie van de 2de achievement bij CocosCatcher
    void CocosCatcherAchievement2()
    {
        if (ScoreScript.scoreValue >= 25 && HeartScript.Health == 3)
        {
            CocosCatcherCheckmark2.SetActive(true);
        }
    }

    //Functie van de 1ste achievement bij CocosCatcher
    void CocosCatcherAchievement3()
    {
        if (ScoreScript.scoreValue >= 20)
        {
            CocosCatcherCheckmark3.SetActive(true);
        }
    }
}
