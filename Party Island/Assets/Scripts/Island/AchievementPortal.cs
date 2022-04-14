using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AchievementPortal : MonoBehaviour
{
    public GameObject AchievementMenu;

    public void OnTriggerEnter(Collider other)
    {
        AchievementMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
    }
}
