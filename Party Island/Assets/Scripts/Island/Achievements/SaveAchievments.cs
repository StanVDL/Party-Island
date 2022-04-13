using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAchievments : MonoBehaviour
{
    public GameObject CocosCatcherCheckmark1, CocosCatcherCheckmark2, CocosCatcherCheckmark3;

    public int SavedValues1;
    public int SavedValues2;
    public int SavedValues3;

    public static int CCatcherCheckmark1;
    public static int CCatcherCheckmark2; 
    public static int CCatcherCheckmark3;

    void Start()
    {
        CCatcherCheckmark1 = PlayerPrefs.GetInt("Checkmark1", SavedValues1);
        CCatcherCheckmark2 = PlayerPrefs.GetInt("Checkmark2", SavedValues2);
        CCatcherCheckmark3 = PlayerPrefs.GetInt("Checkmark3", SavedValues3);
    }

    void Update()
    {
        CheckIfActiveOrNot();

        if (SavedValues1 == 1)
        {
            CocosCatcherCheckmark1.SetActive(true);
        }

        else
        {
            CocosCatcherCheckmark1.SetActive(false);
        }

        if (SavedValues2 == 1)
        {
            CocosCatcherCheckmark2.SetActive(true);
        }

        else
        {
            CocosCatcherCheckmark2.SetActive(false);
        }

        if (SavedValues3 == 1)
        {
            CocosCatcherCheckmark3.SetActive(true);
        }

        else
        {
            CocosCatcherCheckmark3.SetActive(false);
        }
    }

    //If value is 1 than checkmark is shown, otherwise it's hidden//

    void CheckIfActiveOrNot()
    {
        if (CocosCatcherCheckmark1.activeSelf == true)
        {
            SavedValues1 = 1;
        }

        else
        {
            SavedValues1 = 2;
        }

        if (CocosCatcherCheckmark2.activeSelf == true)
        {
            SavedValues2 = 1;
        }

        else
        {
            SavedValues2 = 2;
        }

        if (CocosCatcherCheckmark3.activeSelf == true)
        {
            SavedValues3 = 1;
        }

        else
        {
            SavedValues3 = 2;
        }
    }
}
