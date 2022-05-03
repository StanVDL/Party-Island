using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnRate; //Time between spawns in seconds
    [SerializeField] private Vector2 gapRange;
    [SerializeField] private float gapSize;
    [SerializeField] private float xPos;
    [SerializeField] private float zPos;

    [SerializeField] private ObjectPool tubePool;
    [SerializeField] private ObjectPool scoreTriggerPool;

    void Start()
    {
        GameManager.Instance.OnPlayerDeath.AddListener(OnPlayerDeath);
        StartCoroutine(SpawnAsync());
    }

    private IEnumerator SpawnAsync()
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

    private void OnPlayerDeath()
    {
        StopAllCoroutines();
    }
}
