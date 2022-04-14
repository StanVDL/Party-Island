using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocosSpawner : MonoBehaviour
{
    public GameObject Cocos;
    public GameObject BadCocos;

    public float xBounds, yBound;

    void Start()
    {
        StartCoroutine(SpawnRandomCocos());
    }

    IEnumerator SpawnRandomCocos()
    {
        //Wacht 1 a 2 seconden om de Coconuts te laten spawnen
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomCocos = Random.Range(0, 1);

        if (Random.value <= 0.5f)
        {
            //Code die er voor zorgt dat de goede coconuts op random plaats binnen de ingestelde range valt
            Instantiate(Cocos, new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        }

        else
        {
            //Code die er voor zorgt dat de slechte coconuts op random plaats binnen de ingestelde range valt
            Instantiate(BadCocos, new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        }

        StartCoroutine(SpawnRandomCocos());
    }
    
}
