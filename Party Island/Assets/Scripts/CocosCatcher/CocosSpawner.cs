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
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomCocos = Random.Range(0, 1);

        if (Random.value <= 0.3f)
        {
            Instantiate(Cocos, new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        }

        else
        {
            Instantiate(BadCocos, new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        }

        StartCoroutine(SpawnRandomCocos());
    }
    
}
