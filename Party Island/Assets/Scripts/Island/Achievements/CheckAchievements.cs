using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAchievements : MonoBehaviour
{
    public GameObject CocosCatcherCheckmark1, CocosCatcherCheckmark2, CocosCatcherCheckmark3;
    public GameObject FlappyCocosCheckmark1, FlappyCocosCheckmark2, FlappyCocosCheckmark3;

    void Awake()
    {
        //Haalt de highscore vanuit CocosCatcher reeds op in de lobby zodat de reeds voltooide achievements al inladen in het menu
        ScoreScript.highscoreValue = PlayerPrefs.GetInt("highscores");
        ScoreSystem.highscoreValue2 = PlayerPrefs.GetInt("highscoreFlappys");
    }

    void Update()
    {
        CocosCatcherAchievement1();
        CocosCatcherAchievement2();
        CocosCatcherAchievement3();

        FlappyCocosAchievement1();
        FlappyCocosAchievement2();
        FlappyCocosAchievement3();
    }

    //Functie van de 3de achievement bij CocosCatcher
    void CocosCatcherAchievement3()
    {
        if (ScoreScript.highscoreValue >= 30)
        {
           CocosCatcherCheckmark1.SetActive(true);
        }
    }

    //Functie van de 2de achievement bij CocosCatcher
    void CocosCatcherAchievement2()
    {
        if (ScoreScript.highscoreValue >= 25)
        {
            CocosCatcherCheckmark2.SetActive(true);
        }
    }

    //Functie van de 1ste achievement bij CocosCatcher
    void CocosCatcherAchievement1()
    {
        if (ScoreScript.highscoreValue >= 20)
        {
            CocosCatcherCheckmark3.SetActive(true);
        }
    }

    //Functie van de 1ste achievement bij FlappyCocos
    void FlappyCocosAchievement1()
    {
        if (ScoreSystem.highscoreValue2 >= 15)
        {
            FlappyCocosCheckmark3.SetActive(true);
        }
    }

    //Functie van de 2de achievement bij FlappyCocos
    void FlappyCocosAchievement2()
    {
        if (ScoreSystem.highscoreValue2 >= 25)
        {
            FlappyCocosCheckmark2.SetActive(true);
        }
    }

    //Functie van de 3de achievement bij FlappyCocos
    void FlappyCocosAchievement3()
    {
        if (ScoreSystem.highscoreValue2 >= 50)
        {
            FlappyCocosCheckmark1.SetActive(true);
        }
    }
}
