using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAchievements : MonoBehaviour
{
    public GameObject CocosCatcherCheckmark1, CocosCatcherCheckmark2, CocosCatcherCheckmark3;

    void Update()
    {
        CocosCatcherAchievement1();
        CocosCatcherAchievement2();
        CocosCatcherAchievement3();
    }

    void CocosCatcherAchievement1()
    {
        if (ScoreScript.scoreValue >= 10)
        {
            CocosCatcherCheckmark1.SetActive(true);
        }
    }

    void CocosCatcherAchievement2()
    {
        if (ScoreScript.scoreValue >= 15 && HeartScript.Health == 3)
        {
            CocosCatcherCheckmark2.SetActive(true);
        }
    }

    void CocosCatcherAchievement3()
    {
        if (ScoreScript.scoreValue == 0 && HeartScript.Health == 0)
        {
            CocosCatcherCheckmark3.SetActive(true);
        }
    }
}
