using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Menu;

    public static bool GameIsPaused = false;
    public static bool IsAchievementMenuActive = false;

    //Update functie waarmee gezorgd wordt dat de pauze menu werkt door op escape te drukken
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && IsAchievementMenuActive == false)
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }

    //Functie om de game terug te doen hervatten en het menu te sluiten
    public void Resume()
    {
        Menu.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OptionMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //Functie om de game te pauzeren en het menu te openen
    public void Pause()
    {
        Menu.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
