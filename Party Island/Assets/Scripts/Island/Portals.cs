using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portals : MonoBehaviour
{
    //Zorgt voor een actie wanneer het desbetreffende object geraakt wordt
    public void OnTriggerEnter(Collider other)
    {
        //Switcht naar CocosCatcher en zorgt dat de game zeker start met score 0
        SceneManager.LoadScene(2);
        ScoreScript.scoreValue = 0;
    }
}
