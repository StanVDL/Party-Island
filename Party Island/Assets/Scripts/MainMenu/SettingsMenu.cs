using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public GameObject OptionsMenu;
    public GameObject MainMenu;

    public TMPro.TMP_Dropdown qualityDropdown;

    const string prefName = "optionsvalue";

    void Awake()
    {
        qualityDropdown.onValueChanged.AddListener(new UnityAction<int>(index =>
            {
                PlayerPrefs.SetInt(prefName, qualityDropdown.value);
            }));
    }

    void Start()
    {
        qualityDropdown.value = PlayerPrefs.GetInt(prefName, 3);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void BackToMainMenu()
    {
        OptionsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
