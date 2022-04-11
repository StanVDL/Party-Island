using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocosFunctions : MonoBehaviour
{
    public GameObject GoodCoconut;
    public GameObject BadCoconut;

    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Crate" && gameObject == GoodCoconut)
        {
            Destroy(gameObject);
            ScoreScript.instance.AddPoint();
        }

        if (collision.gameObject.tag == "Crate" && gameObject == BadCoconut)
        {
            Destroy(gameObject);
            HeartScript.Health -= 1;
        }
    }


}
