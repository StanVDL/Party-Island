using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate; //Tijd tussen de spawns in seconden
    public Vector2 gapRange;
    public float gapSize;
    public float xPos;
    public float zPos;

    public ObjectPool tubePool;
    public ObjectPool scoreTriggerPool;

    void Start()
    {
        GameManager.Instance.OnPlayerDeath.AddListener(OnPlayerDeath);
        StartCoroutine(SpawnAsync());
    }

    //Bepaald de spawn gegevens van de tubes in FlappyCocos
    public IEnumerator SpawnAsync()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);

            //Spawn tubes
            var topTube = tubePool.GetFromPool();
            var bottomTube = tubePool.GetFromPool();
            var scoreTrigger = scoreTriggerPool.GetFromPool();

            var gapPosition = Random.Range(gapRange.x, gapRange.y);
            scoreTrigger.transform.position = new Vector3(xPos, gapPosition, zPos);
            bottomTube.transform.position = new Vector3(xPos, gapPosition - gapSize - bottomTube.transform.localScale.y/2, zPos);
            topTube.transform.position = new Vector3(xPos, gapPosition + gapSize + topTube.transform.localScale.y/2, zPos);
        }
    }

    //Stopt alle acties wanneer player dood is
    public void OnPlayerDeath()
    {
        StopAllCoroutines();
    }
}
