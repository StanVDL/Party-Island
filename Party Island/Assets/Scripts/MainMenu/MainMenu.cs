using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionsMenus;
    public GameObject MainMenus;

    //Functie om naar de lobby te gaan vanuit het hoofdmenu
    public void PlayGame()
    {
        SceneManager.LoadScene("Island");
        Time.timeScale = 1;
    }

    //Functie om naar de settingsmenu te gaan vanuit het hoofdmenu
    public void OptionsMenu()
    {
        OptionsMenus.SetActive(true);
        MainMenus.SetActive(false);
    }

    //Functie om het spel en de applicatie volledig af te sluiten
    public void Quit()
    {
        Application.Quit();
    }
}
