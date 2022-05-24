using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AchievementPortal : MonoBehaviour
{
    public GameObject AchievementMenu;

    int HighscoreValueCheck;
    int HighscoreValueCheck2;

    private void Awake()
    {
        HighscoreValueCheck = PlayerPrefs.GetInt("highscores");
        HighscoreValueCheck2 = PlayerPrefs.GetInt("highscoreFlappys");
    }

    //Zorgt ervoor dat het achievement menu geopend wordt wanneer het portaal wordt aangeraakt
    public void OnTriggerEnter(Collider other)
    {
        AchievementMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        PauseMenu.IsAchievementMenuActive = true;
    }
}
