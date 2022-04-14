using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsAchievement : MonoBehaviour
{
    public GameObject AchievementMenu;
    public GameObject CocosCatcherMenu;
    public GameObject FlappyCocosMenu;
    public GameObject MainAchievementMenu;

    //Functie om volledig terug te gaan uit het achievement menu
    public void BackButton()
    {
        AchievementMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        PauseMenu.IsAchievementMenuActive = false;
    }

    //Functie om terug te gaan naar de hoofdpagina van het achievement menu
    public void BackFromSecondPage()
    {
        CocosCatcherMenu.SetActive(false);
        MainAchievementMenu.SetActive(true);
    }

    //Functie om de pagina van CocosCatcher te openen in het achievement menu
    public void CocosCatcherAchievements()
    {
        MainAchievementMenu.SetActive(false);
        CocosCatcherMenu.SetActive(true);
    }
}
