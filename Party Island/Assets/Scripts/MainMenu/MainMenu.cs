using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionsMenus;
    public GameObject MainMenus;

    public void PlayGame()
    {
        SceneManager.LoadScene("Island");
    }

    public void OptionsMenu()
    {
        OptionsMenus.SetActive(true);
        MainMenus.SetActive(false);

    }
}
