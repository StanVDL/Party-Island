using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsAchievement : MonoBehaviour
{
    public GameObject AchievementMenu;
    public GameObject CocosCatcherMenu;
    public GameObject FlappyCocosMenu;
    public GameObject MainAchievementMenu;

    public void BackButton()
    {
        AchievementMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        PauseMenu.IsAchievementMenuActive = false;
    }

    public void BackFromSecondPage()
    {
        CocosCatcherMenu.SetActive(false);
        MainAchievementMenu.SetActive(true);
    }

    public void CocosCatcherAchievements()
    {
        MainAchievementMenu.SetActive(false);
        CocosCatcherMenu.SetActive(true);
    }
}
