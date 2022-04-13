using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsAchievement : MonoBehaviour
{
    public GameObject AchievementMenu;

    public void BackButton()
    {
        AchievementMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
