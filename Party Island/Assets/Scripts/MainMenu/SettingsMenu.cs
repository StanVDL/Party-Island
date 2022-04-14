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
        //Zorgt dat de nieuw gekozen kwaliteit opgeslagen wordt
        qualityDropdown.onValueChanged.AddListener(new UnityAction<int>(index =>
            {
                PlayerPrefs.SetInt(prefName, qualityDropdown.value);
            }));
    }

    void Start()
    {
        //Haalt de laatst opgeslagen waarden van de qualityDropdown op en indien deze nog nooit is aangepast heeft deze standaardwaarde 3 = 3de layer
        qualityDropdown.value = PlayerPrefs.GetInt(prefName, 3);
    }

    //Functie voor het instellen van de grafische kwaliteit
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    //Functie om vanuit het settingsmenu terug te gaan naar het hoofdmenu
    public void BackToMainMenu()
    {
        OptionsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
